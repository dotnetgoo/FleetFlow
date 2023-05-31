using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
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
    private readonly IRepository<Cart> cartRepository;
    private readonly IRepository<Order> orderRepository;
    private readonly IRepository<User> userRepository;
    //private readonly IOrderActionService orderActionService;
    private readonly IPaymentService paymentService;
    private readonly IAddressService addressService;

    public OrderService(IRepository<Order> orderRepository,
        IRepository<Cart> cartRepository,
        IRepository<User> userRepository,
        IMapper mapper,
        //  IOrderActionService orderActionService,
        IAddressService addressService,
        IPaymentService paymentService)
    {
        this.orderRepository = orderRepository;
        this.cartRepository = cartRepository;
        this.mapper = mapper;
        this.userRepository = userRepository;
        //this.orderActionService = orderActionService;
        this.addressService = addressService;
        this.paymentService = paymentService;
    }

    public async ValueTask<OrderResultDto> AddAsync(OrderForCreationDto orderForCreationDto)
    {
        // existance of address and payment
        await this.addressService.GetByIdAsync(orderForCreationDto.AddressId);
        await this.paymentService.RetrieveByIdAsync(orderForCreationDto.PaymentId);

        var cart = await cartRepository.SelectAsync(c => c.UserId == HttpContextHelper.UserId, new string[] { "Items" });
        if (cart == null)
            throw new FleetFlowException(404, "Cart not found");


        // create new order
        var order = new Order()
        {
            UserId = HttpContextHelper.UserId ?? 0,
            OrderItems = new List<OrderItem>(),
            PaymentId = orderForCreationDto.PaymentId,
            AddressId = orderForCreationDto.AddressId
        };

        // create order items using cart
        foreach (var cartItem in cart.Items)
        {
            order.OrderItems.Add(new OrderItem
            {
                Amount = cartItem.Amount,
                ProductId = cartItem.ProductId

            });
        }

        var createdOrder = await orderRepository.InsertAsync(order);
        await orderRepository.SaveAsync();

        ///@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        ///Circular injection detected
        //await this.orderActionService.StartPendingAsync((int)order.Id);
        ///@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

        return mapper.Map<OrderResultDto>(createdOrder);
    }

    public async ValueTask<bool> ChangeStatusAsync(long orderId, OrderStatus status)
    {
        var order = await this.orderRepository.SelectAsync(order => order.Id == orderId);
        if (order is null)
            throw new FleetFlowException(404, "Order is not found.");
        order.Status = status;
        await this.orderRepository.SaveAsync();
        return true;
    }

    //public async ValueTask<OrderResultDto> CancelAsync(long id)
    //{
    //    var order = await orderRepository.SelectAsync(order => !order.IsDeleted && order.Id == id, new string[] { "User", "Actions" });
    //    if (order is null)
    //        throw new FleetFlowException(404, "Order is not found");


    //    // TODO: Add business logic for canceled order.
    //    // Returning products to warehouse, assignments to workers 

    //    /* order.Status = OrderStatus.Cancelled;

    //     // Creating new order action
    //     order.Actions.Add(new OrderAction() { Status = OrderStatus.Cancelled });

    //     await orderRepository.SaveAsync();*/

    //    var result = mapper.Map<OrderResultDto>(await this.orderActionService.CancelledAsync((int)order.Id));
    //    // is this best practice to avoid object cycle?
    //    result.User.Orders = null;

    //    return result;
    //}

    public async ValueTask<bool> RemoveAsync(long id)
    {
        var isDeleted = await orderRepository.DeleteAsync(order => order.Id == id);
        if (!isDeleted)
            throw new FleetFlowException(404, "Order is not found");

        return isDeleted;
    }

    public async ValueTask<IEnumerable<OrderResultDto>> RetrieveAllAsync(PaginationParams @params, OrderStatus status = OrderStatus.Pending)
    {
        var orders = await orderRepository
            .SelectAll(order => !order.IsDeleted && order.Status == status)
            .ToPagedList(@params)
            .ToListAsync();
        // checking something exists or not
        if (!orders.Any())
            throw new FleetFlowException(400, "No orders found.");

        return mapper.Map<IEnumerable<OrderResultDto>>(orders);
    }

    public async ValueTask<IEnumerable<OrderResultDto>> RetrieveAllByClientIdAsync(long clientId)
    {
        var orders = await orderRepository
            .SelectAll(order => !order.IsDeleted && order.UserId == clientId)
            .ToListAsync();
        // checking something exists or not
        if (!orders.Any())
            throw new FleetFlowException(400, "No orders found.");

        return mapper.Map<IEnumerable<OrderResultDto>>(orders);
    }

    public async ValueTask<IEnumerable<OrderResultDto>> RetrieveAllByPhoneAsync(PaginationParams @params, string phone, OrderStatus? status = null)
    {
        var user = await userRepository.SelectAsync(user => !user.IsDeleted && user.Phone == phone);
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
        var order = await orderRepository.SelectAsync(order => !order.IsDeleted && order.Id == id);
        if (order is null)
            throw new FleetFlowException(404, "Order is not found");

        return mapper.Map<OrderResultDto>(order);
    }
}
