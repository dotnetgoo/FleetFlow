using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Entities.Orders;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Interfaces.Orders;

namespace FleetFlow.Service.Services.Orders;

public class OrderActionService : IOrderActionService
{
    protected readonly IRepository<Order> orderRepository;
    public OrderActionService(IRepository<Order> orderRepository)
    {
        this.orderRepository = orderRepository;
    }

    public async ValueTask<Order> CancelledAsync(int id)
    {
        var order = await this.orderRepository.SelectAsync(x => x.Id == id);
        if (order is null)
            throw new FleetFlowException(404, "Order is not found");

        order.Id = id;
        order.Status = OrderStatus.Cancelled;

        order.Actions.Add(new OrderAction() { Status = OrderStatus.Cancelled });

        await orderRepository.SaveAsync();

        return order;
    }

    public async ValueTask<Order> FinishDelivery(int id)
    {
        var order = await this.orderRepository.SelectAsync(x => x.Id == id);
        if (order is null)
            throw new FleetFlowException(404, "Order is not found");

        order.Id = id;
        order.Status = OrderStatus.Shipped;

        order.Actions.Add(new OrderAction() { Status = OrderStatus.Shipped });

        await orderRepository.SaveAsync();

        return order;
    }

    public async ValueTask<Order> StartPendingAsync(int id)
    {
        var order = await this.orderRepository.SelectAsync(x => x.Id == id);
        if (order is null)
            throw new FleetFlowException(404, "Order is not found");

        order.Id = id;
        order.Status = OrderStatus.Pending;

        order.Actions.Add(new OrderAction() { Status = OrderStatus.Pending });

        await orderRepository.SaveAsync();

        return order;
    }

    public async ValueTask<Order> StartPreparingAsync(int id)
    {
        var order = await this.orderRepository.SelectAsync(x => x.Id == id);
        if (order is null)
            throw new FleetFlowException(404, "Order is not found");

        order.Id = id;
        order.Status = OrderStatus.Process;

        order.Actions.Add(new OrderAction() { Status = OrderStatus.Process });

        await orderRepository.SaveAsync();

        return order; ;
    }

    public async ValueTask<Order> StartShippingAsync(int id)
    {
        var order = await this.orderRepository.SelectAsync(x => x.Id == id);
        if (order is null)
            throw new FleetFlowException(404, "Order is not found");

        order.Id = id;
        order.Status = OrderStatus.Shipping;

        order.Actions.Add(new OrderAction() { Status = OrderStatus.Shipping });

        await orderRepository.SaveAsync();

        return order;
    }
}
