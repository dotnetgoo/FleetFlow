using FleetFlow.Service.DTOs.Orders;

namespace FleetFlow.Service.Interfaces.Orders;

public interface IOrderActionService
{
    ValueTask<OrderResultDto> StartPendingAsync(long orderId);
    ValueTask<OrderResultDto> StartPreparingAsync(long orderId);
    ValueTask<OrderResultDto> StartShippingAsync(long orderId);
    ValueTask<OrderResultDto> FinishDeliveryAsync(long orderId);
    ValueTask<OrderResultDto> CancelledAsync(long orderId);
}
