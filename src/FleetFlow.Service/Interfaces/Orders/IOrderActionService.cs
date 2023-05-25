using FleetFlow.Domain.Entities.Orders;

namespace FleetFlow.Service.Interfaces.Orders;

public interface IOrderActionService
{
    ValueTask<Order> StartPendingAsync(int id);
    ValueTask<Order> StartPreparingAsync(int id);
    ValueTask<Order> StartShippingAsync(int id);
    ValueTask<Order> FinishDelivery(int id);
    ValueTask<Order> CancelledAsync(int id);
}
