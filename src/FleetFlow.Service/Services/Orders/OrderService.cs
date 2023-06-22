using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Entities.Addresses;
using FleetFlow.Domain.Entities.Orders;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.Addresses;
using FleetFlow.Service.Interfaces.Orders;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.Orders;

public class OrderService : IOrderService
{
    private readonly IMapper mapper;
    private readonly IPaymentService paymentService;
    private readonly IAddressService addressService;
    private readonly IRepository<Cart> cartRepository;
    private readonly IRepository<CartItem> cartItemRepository;
    private readonly IRepository<User> userRepository;
    private readonly IRepository<Order> orderRepository;
    private readonly IRepository<Region> regionRepository;
    private readonly IRepository<District> districtRepository;
    public OrderService(
        IMapper mapper,
        IAddressService addressService,
        IPaymentService paymentService,
        IRepository<Cart> cartRepository,
        IRepository<User> userRepository,
        IRepository<Order> orderRepository,
        IRepository<Region> regionRepository,
        IRepository<District> districtRepository,
        IRepository<CartItem> cartItemRepository)
    {
        this.mapper = mapper;
        this.addressService = addressService;
        this.paymentService = paymentService;
        this.cartRepository = cartRepository;
        this.userRepository = userRepository;
        this.orderRepository = orderRepository;
        this.regionRepository = regionRepository;
        this.districtRepository = districtRepository;
        this.cartItemRepository = cartItemRepository;
    }

    public async ValueTask<OrderResultDto> AddAsync(OrderForCreationDto orderForCreationDto)
    {
        // existance of address and payment
        var address = await this.addressService.GetByIdAsync(orderForCreationDto.AddressId);

        Region region = await this.regionRepository.SelectAsync(t => t.Id == orderForCreationDto.RegionId);
        if (region is null)
            throw new FleetFlowException(404, "Region is not found");

        District district = await this.districtRepository.SelectAsync(t => t.Id == orderForCreationDto.DistrictId);
        if (district is null)
            throw new FleetFlowException(404, "District is not found");

        Cart cart = await cartRepository.SelectAsync(c => c.UserId == HttpContextHelper.UserId, new string[] { "Items.Product" });
        if (cart == null)
            throw new FleetFlowException(404, "Cart not found");

        var cartItems = await this.cartItemRepository
            .SelectAll(t => !t.IsDeleted && t.CartId == cart.Id && !t.IsOrdered, includes: new string[] { "Product" })
            .ToListAsync();

        if (!cartItems.Any())
            throw new FleetFlowException(404, "CartItems not found");
        // create new order
        var order = new Order()
        {
            UserId = HttpContextHelper.UserId ?? 0,
            OrderItems = new List<OrderItem>(),
            AddressId = orderForCreationDto.AddressId,
            RegionId = orderForCreationDto.RegionId,
            DistrictId = orderForCreationDto.DistrictId,
        };

        // create order items using cart
        foreach (var cartItem in cartItems)
        {
            order.OrderItems.Add(new OrderItem
            {
                Id = cartItem.Id,
                AmountTotal = cartItem.AmountTotal,
                CreatedAt = cartItem.CreatedAt,
                ProductId = cartItem.ProductId,
                Amount = cartItem.Amount,
            });
            cartItem.IsOrdered = true;
            order.TotalAmount += cartItem.Product.Price;
        }

        await this.cartItemRepository.SaveAsync();
        var createdOrder = await orderRepository.InsertAsync(order);
        await orderRepository.SaveAsync();

        return mapper.Map<OrderResultDto>(createdOrder);
    }

    public async ValueTask<bool> RemoveAsync(long id)
    {
        var isDeleted = await orderRepository.DeleteAsync(order => order.Id == id);
        if (!isDeleted)
            throw new FleetFlowException(404, "Order is not found");

        return isDeleted;
    }

    public async ValueTask<IEnumerable<OrderResultDto>> RetrieveAllAsync(PaginationParams @params, OrderStatus? status = null)
    {
        var orders = orderRepository.SelectAll(order => !order.IsDeleted,
            new string[] { "User", "Address", "Region", "District", "OrderItems" }).AsQueryable();

        // filter with status
        if (status is not null)
            orders = orders.Where(order => order.Status == status);

        // checking something exists or not
        if (!orders.Any())
            throw new FleetFlowException(400, "No orders found.");

        var pagedOrders = await orders.ToPagedList(@params).ToListAsync();
        return mapper.Map<IEnumerable<OrderResultDto>>(pagedOrders);
    }

    public async ValueTask<IEnumerable<OrderResultDto>> RetrieveAllByClientIdAsync(long clientId)
    {
        var orders = await orderRepository
            .SelectAll(order => !order.IsDeleted && order.UserId == clientId, new string[] { "User", "Address", "Region", "District", "OrderItems" })
            .ToListAsync();
        // checking something exists or not
        if (!orders.Any())
            throw new FleetFlowException(400, "No orders found.");

        return mapper.Map<IEnumerable<OrderResultDto>>(orders);
    }

    public async ValueTask<IEnumerable<OrderResultDto>> RetrieveAllByPhoneAsync(PaginationParams @params, string phone, OrderStatus? status = null)
    {
        var user = await userRepository.SelectAsync(user => !user.IsDeleted && user.Phone == phone,
            new string[] { "Orders.OrderItems" });
        if (user is null)
            throw new FleetFlowException(404, "User is not found");

        var ordersQuery = orderRepository
            .SelectAll(order => !order.IsDeleted && order.UserId == user.Id);
        if (status is not null)
            ordersQuery = ordersQuery.Where(order => order.Status == status);

        ordersQuery = ordersQuery.ToPagedList(@params);

        var orders = await ordersQuery.ToListAsync();

        // checking something exists or not
        if (!orders.Any())
            throw new FleetFlowException(400, "No orders found.");

        return mapper.Map<IEnumerable<OrderResultDto>>(orders);
    }

    public async ValueTask<OrderResultDto> RetrieveAsync(long id)
    {
        var order = await orderRepository.SelectAsync(order => !order.IsDeleted && order.Id == id,
            new string[] { "User", "Address", "Region", "District", "OrderItems" });
        if (order is null)
            throw new FleetFlowException(404, "Order is not found");

        return mapper.Map<OrderResultDto>(order);
    }
}
