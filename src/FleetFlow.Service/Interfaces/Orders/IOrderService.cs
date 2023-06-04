﻿using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.DTOs.Payments;

namespace FleetFlow.Service.Interfaces.Orders
{
    public interface IOrderService
    {
        ValueTask<OrderResultDto> AddAsync(OrderForCreationDto orderForCreationDto);
        ValueTask<bool> RemoveAsync(long id);
        ValueTask<OrderResultDto> RetrieveAsync(long id);
        ValueTask<IEnumerable<OrderResultDto>> RetrieveAllByClientIdAsync(long clientId);
        ValueTask<IEnumerable<OrderResultDto>> RetrieveAllAsync(
            PaginationParams @params = null, OrderStatus? status = null);
        ValueTask<IEnumerable<OrderResultDto>> RetrieveAllByPhoneAsync(
            string phone, PaginationParams @params = null, OrderStatus? status = null);
    }
}
