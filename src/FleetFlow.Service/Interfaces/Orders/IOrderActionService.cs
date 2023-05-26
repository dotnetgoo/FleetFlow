using FleetFlow.Domain.Entities.Orders;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.Services.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.Interfaces.Orders;

public interface IOrderActionService
{
    ValueTask<OrderResultDto> StartPendingAsync(int orderId);
    ValueTask<OrderResultDto> StartPreparingAsync(int orderId);
    ValueTask<OrderResultDto> StartShippingAsync(int orderId);
    ValueTask<OrderResultDto> FinishDelivery(int orderId);
    ValueTask<OrderResultDto> CancelledAsync(int orderId);
}
