using FleetFlow.Domain.Enums;
using FleetFlow.Shared.Helpers;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Service.Exceptions;
using Microsoft.EntityFrameworkCore;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Domain.Entities.Orders;
using FleetFlow.Service.Interfaces.Orders;
using FleetFlow.Service.DTOs.InventoryLogs;
using FleetFlow.Service.Interfaces.Addresses;
using FleetFlow.Service.Interfaces.Warehouses;

namespace FleetFlow.Service.Services.Orders;

public class OrderActionService : IOrderActionService
{
    private readonly ICartService cartService;
    private readonly IOrderService orderService;
    private readonly IAddressService addressService;
    private readonly IInventoryLogService inventoryLogService;
    private readonly IRepository<OrderAction> actionRepository;
    private readonly IRepository<OrderItem> orderItemRepository;
    private readonly IProductInventoryService productInventoryService;
    public OrderActionService(
        IOrderService orderService,
        IAddressService addressService,
        IInventoryLogService inventoryLogService,
        IRepository<OrderAction> actionRepository,
        IRepository<OrderItem> orderItemRepository,
        IProductInventoryService productInventoryAssignmentService)
    {
        this.orderService = orderService;
        this.addressService = addressService;
        this.actionRepository = actionRepository;
        this.inventoryLogService = inventoryLogService;
        this.orderItemRepository = orderItemRepository;
        this.productInventoryService = productInventoryAssignmentService;
    }

    public async ValueTask<OrderResultDto> CancelledAsync(int orderId)
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

    public async ValueTask<OrderResultDto> FinishDeliveryAsync(int orderId)
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

    public async ValueTask<OrderResultDto> StartPendingAsync(OrderActionCreationDto action)
    {
        var order = await this.orderService.RetrieveAsync(action.OrderId);
        if (order is null)
            throw new FleetFlowException(404, "Order is not found");

        order.Status = OrderStatus.Pending;

        await this.actionRepository.InsertAsync(new OrderAction() { OrderId = order.Id, Status = OrderStatus.Pending });
        await this.actionRepository.SaveAsync();

        return order;
    }

    public async ValueTask<OrderResultDto> StartPreparingAsync(OrderActionCreationDto action)
    {
        var order = await this.orderService.RetrieveAsync(action.OrderId);
        if (order is null)
            throw new FleetFlowException(404, "Order is not found");

        order.Status = OrderStatus.Process;

        await this.actionRepository.InsertAsync(new OrderAction() { OrderId = order.Id, Status = OrderStatus.Process });
        await this.actionRepository.SaveAsync();

        return order;
    }

    public async ValueTask<OrderResultDto> StartShippingAsync(OrderActionCreationDto action)
    {
        var order = await this.orderService.RetrieveAsync(action.OrderId);
        if (order is null)
            throw new FleetFlowException(404, "Order is not found");

        var address = await this.addressService.GetByIdAsync(order.AddressId);

        order.Status = OrderStatus.Shipping;
        await this.actionRepository.InsertAsync(new OrderAction() { OrderId = order.Id, Status = OrderStatus.Shipping });

        long inventoryId = SearchNearestInventory(address.Latitude, address.Longitude);

        // create order items using cart
        foreach (var cartItem in order.OrderItems)
        {
            await this.productInventoryService.RemoveQuantity(cartItem.ProductId, inventoryId, cartItem.Amount);

            var inventoryLog = new InventoryLogForCreationDto()
            {
                ProductId = cartItem.ProductId,
                Amount = cartItem.Amount,
                Type = InventoryLogType.Minus,
                OwnerId = (long)HttpContextHelper.UserId,
                InventoryId = inventoryId
            };

            await this.inventoryLogService.AddAsync(inventoryLog);
        }
        await this.actionRepository.SaveAsync();

        return order;
    }

    // Qilish kerak!!!
    private long SearchNearestInventory(double lat, double lon)
    {
        throw new NotImplementedException();
    }
}
