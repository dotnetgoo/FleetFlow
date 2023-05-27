using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Entities.Orders;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Interfaces.Orders;
using FleetFlow.Service.Interfaces.Warehouses;
using MailKit.Search;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.Orders;

public class OrderActionService : IOrderActionService
{
    protected readonly IOrderService orderService;
    protected readonly IRepository<OrderItem> orderItemRepository;
    protected readonly IRepository<OrderAction> actionRepository;
    protected readonly IProductInventoryAssignmentService productInventoryAssignmentService;
    public OrderActionService(IRepository<OrderAction> actionRepository, IOrderService orderService, IProductInventoryAssignmentService productInventoryAssignmentService, IRepository<OrderItem> orderItemRepository)
    {
        this.actionRepository = actionRepository;
        this.orderService = orderService;
        this.productInventoryAssignmentService = productInventoryAssignmentService;
        this.orderItemRepository = orderItemRepository;
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

    public async ValueTask<OrderResultDto> FinishDelivery(int orderId)
    {
        var order = await this.orderService.RetrieveAsync(orderId);
        if (order is null)
            throw new FleetFlowException(404, "Order is not found");

        order.Id = orderId;
        order.Status = OrderStatus.Cancelled;

        await this.actionRepository.InsertAsync(new OrderAction() { OrderId = orderId, Status = OrderStatus.Shipped });

        await this.actionRepository.SaveAsync();

        return order;
    }

    public async ValueTask<OrderResultDto> StartPendingAsync(int orderId)
    {
        var order = await this.orderService.RetrieveAsync(orderId);
        if (order is null)
            throw new FleetFlowException(404, "Order is not found");

        order.Id = orderId;
        order.Status = OrderStatus.Cancelled;

        await this.actionRepository.InsertAsync(new OrderAction() { OrderId = orderId, Status = OrderStatus.Pending });

        await this.actionRepository.SaveAsync();

        return order;
    }

    public async ValueTask<OrderResultDto> StartPreparingAsync(int orderId)
    {
        var order = await this.orderService.RetrieveAsync(orderId);
        if (order is null)
            throw new FleetFlowException(404, "Order is not found");

        order.Id = orderId;
        order.Status = OrderStatus.Cancelled;

        await this.actionRepository.InsertAsync(new OrderAction() { OrderId = orderId, Status = OrderStatus.Process });

        await this.actionRepository.SaveAsync();

        return order;
    }

    public async ValueTask<OrderResultDto> StartShippingAsync(int orderId)
    {
        var order = await this.orderService.RetrieveAsync(orderId);
        if (order is null)
            throw new FleetFlowException(404, "Order is not found");

        order.Id = orderId;
        order.Status = OrderStatus.Cancelled;

        await this.actionRepository.InsertAsync(new OrderAction() { OrderId = orderId, Status = OrderStatus.Shipping });

        await this.actionRepository.SaveAsync();

        return order;
    }
}
