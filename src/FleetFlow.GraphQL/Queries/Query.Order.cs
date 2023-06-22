using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.Interfaces.Orders;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<OrderResultDto> GetOrderByIdAsync([Service] IOrderService service, long id)
        {
            return await service.RetrieveAsync(id);
        }
        public async ValueTask<IEnumerable<OrderResultDto>> GetOrderAllAsync([Service] IOrderService service, PaginationParams @params)
        {
            return await service.RetrieveAllAsync(@params);
        }
        public async ValueTask<IEnumerable<OrderResultDto>> GetOrderAllByClientIdAsync([Service] IOrderService service, long clientId)
        {
            return await service.RetrieveAllByClientIdAsync(clientId);
        }
        public async ValueTask<IEnumerable<OrderResultDto>> GetOrderAllByPhoneAsync([Service] IOrderService service, PaginationParams @params,
            string phone, OrderStatus? status = null)
        {
            return await service.RetrieveAllByPhoneAsync(@params, phone, status);
        }
    }
}
