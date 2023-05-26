using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.DTOs.Payments;

namespace FleetFlow.Service.Interfaces.Orders
{
    public interface IOrderService
    {
        ValueTask<OrderResultDto> AddAsync(OrderForCreationDto orderForCreationDto);
        ValueTask<IEnumerable<OrderResultDto>> RetrieveAllAsync(PaginationParams @params, OrderStatus status = OrderStatus.Pending);
        ValueTask<OrderResultDto> RetrieveAsync(long id);
        ValueTask<bool> RemoveAsync(long id);
        ValueTask<IEnumerable<OrderResultDto>> RetrieveAllByClientIdAsync(long clientId);
        ValueTask<IEnumerable<OrderResultDto>> RetrieveAllByPhoneAsync(PaginationParams @params, string phone, OrderStatus? status = null);
    }
}
