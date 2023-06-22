using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Google;
using FleetFlow.Domain.Entities.Orders;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Inventories;
using FleetFlow.Service.DTOs.InventoryLogs;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Interfaces.Addresses;
using FleetFlow.Service.Interfaces.Orders;
using FleetFlow.Service.Interfaces.Warehouses;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace FleetFlow.Service.Services.Orders;

public class OrderActionService : IOrderActionService
{
    private readonly ICartService cartService;
    private readonly IOrderService orderService;
    private readonly IAddressService addressService;
    private readonly IInventoryService inventoryService;
    private readonly IInventoryLogService inventoryLogService;
    private readonly IRepository<OrderAction> actionRepository;
    private readonly IRepository<OrderItem> orderItemRepository;
    private readonly IProductInventoryService productInventoryService;
    public OrderActionService(
        IOrderService orderService,
        IAddressService addressService,
        IInventoryService inventoryService,
        IInventoryLogService inventoryLogService,
        IRepository<OrderAction> actionRepository,
        IRepository<OrderItem> orderItemRepository,
        IProductInventoryService productInventoryAssignmentService)
    {
        this.orderService = orderService;
        this.addressService = addressService;
        this.actionRepository = actionRepository;
        this.inventoryService = inventoryService;
        this.inventoryLogService = inventoryLogService;
        this.orderItemRepository = orderItemRepository;
        this.productInventoryService = productInventoryAssignmentService;
    }

    public async ValueTask<OrderResultDto> CancelledAsync(long orderId)
    {
        var order = await this.orderService.RetrieveAsync(orderId);
        if (order is null)
            throw new FleetFlowException(404, "Order is not found");

        var orderItems = await this.orderItemRepository.SelectAll(x => x.OrderId == orderId).ToListAsync();

        order.Id = orderId;
        order.Status = OrderStatus.Cancelled;

        await this.actionRepository.InsertAsync(new OrderAction() { OrderId = orderId, Status = OrderStatus.Cancelled });
        await this.actionRepository.SaveAsync();

        return order;
    }

    public async ValueTask<OrderResultDto> FinishDeliveryAsync(long orderId)
    {
        var order = await this.orderService.RetrieveAsync(orderId);
        if (order is null)
            throw new FleetFlowException(404, "Order is not found");

        order.Id = orderId;
        order.Status = OrderStatus.Shipped;

        await this.actionRepository.InsertAsync(new OrderAction() { OrderId = orderId, Status = OrderStatus.Shipped });
        await this.actionRepository.SaveAsync();

        return order;
    }

    public async ValueTask<OrderResultDto> StartPendingAsync(long orderId)
    {
        var order = await this.orderService.RetrieveAsync(orderId);
        if (order is null)
            throw new FleetFlowException(404, "Order is not found");

        order.Status = OrderStatus.Pending;

        await this.actionRepository.InsertAsync(new OrderAction() { OrderId = order.Id, Status = OrderStatus.Pending });
        await this.actionRepository.SaveAsync();

        return order;
    }

    public async ValueTask<OrderResultDto> StartPreparingAsync(long orderId)
    {
        var order = await this.orderService.RetrieveAsync(orderId);
        if (order is null)
            throw new FleetFlowException(404, "Order is not found");

        order.Status = OrderStatus.Process;

        await this.actionRepository.InsertAsync(new OrderAction() { OrderId = order.Id, Status = OrderStatus.Process });
        await this.actionRepository.SaveAsync();

        return order;
    }

    public async ValueTask<OrderResultDto> StartShippingAsync(long orderId)
    {
        var order = await this.orderService.RetrieveAsync(orderId);
        if (order is null)
            throw new FleetFlowException(404, "Order is not found");

        var address = await this.addressService.GetByIdAsync(order.AddressId);

        order.Status = OrderStatus.Shipping;
        await this.actionRepository.InsertAsync(new OrderAction() { OrderId = order.Id, Status = OrderStatus.Shipping });

        var inventory = await SearchNearestInventory(address.Latitude, address.Longitude);

        // create order items using cart
        foreach (var cartItem in order.OrderItems)
        {
            await this.productInventoryService.RemoveQuantity(cartItem.ProductId, inventory.Id, cartItem.Amount);

            var inventoryLog = new InventoryLogForCreationDto()
            {
                ProductId = cartItem.ProductId,
                Amount = cartItem.Amount,
                Type = InventoryLogType.Minus,
                OwnerId = (long)HttpContextHelper.UserId,
                InventoryId = inventory.Id
            };

            await this.inventoryLogService.AddAsync(inventoryLog);
        }
        await this.actionRepository.SaveAsync();

        return order;
    }

    private async ValueTask<InventoryForResultDto> SearchNearestInventory(double lat, double lon)
    {
        var destinations = await this.inventoryService.RetrieveAllInventory(new PaginationParams());

        long nearestDestination = 0;
        double minDistance = double.PositiveInfinity;

        foreach (var destination in destinations)
        {
            double distance = await CalculateDistance(lat, lon, destination);

            if (distance < minDistance)
            {
                minDistance = distance;
                nearestDestination = destination.Id;
            }
        }
        var inventory = await this.inventoryService.RetrieveById(nearestDestination);
        return inventory;
    }

    private async Task<double> CalculateDistance(double lat, double lon, InventoryForResultDto destination)
    {
        string GoogleMapsApiUrl = "https://maps.googleapis.com/maps/api/directions/json";
        string GoogleMapsApiKey = "AIzaSyBLHCo7zVzMZwcvzSnmva_lVV4_lfFHeeI";

        /// var address = await this.addressService.GetByIdAsync(destination.AddressId);

        string requestUrl = $"{GoogleMapsApiUrl}?origin={lat},{lon}&destination={destination.Address.Latitude},{destination.Address.Longitude}&key={GoogleMapsApiKey}";

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(requestUrl);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<GoogleMapsDirectionResponse>(content);

                if (result != null && result.Routes.Count > 0)
                {
                    var route = result.Routes[0];

                    if (route.Legs.Count > 0)
                    {
                        var leg = route.Legs[0];
                        double distanceInMeters = leg.Distance.Value;
                        double distanceInKilometers = distanceInMeters / 1000;

                        return distanceInKilometers;
                    }
                }
            }
        }
        return double.PositiveInfinity;
    }
}
