using FleetFlow.Service.DTOs.Inventories;
using FleetFlow.Service.DTOs.Orders;

namespace FleetFlow.Service.Interfaces.Orders;

public interface IOrderActionService
{
    ValueTask<OrderResultDto> StartPendingAsync(OrderActionCreationDto action);
    ValueTask<OrderResultDto> StartPreparingAsync(OrderActionCreationDto action);
    ValueTask<OrderResultDto> StartShippingAsync(OrderActionCreationDto action);
    ValueTask<OrderResultDto> FinishDeliveryAsync(int orderId);
    ValueTask<OrderResultDto> CancelledAsync(int orderId);
}
