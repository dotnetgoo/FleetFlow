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
    ValueTask<Order> StartPendingAsync(int id);
    ValueTask<Order> StartPreparingAsync(int id);
    ValueTask<Order> StartShippingAsync(int id);
    ValueTask<Order> FinishDelivery(int id);
    ValueTask<Order> CancelledAsync(int id);
}
