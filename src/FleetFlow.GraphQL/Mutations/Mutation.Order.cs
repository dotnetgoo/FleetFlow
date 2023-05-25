using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.Interfaces.Orders;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<OrderResultDto> CreateOrderAsync([Service] IOrderService orderService)
        {
            return await orderService.AddAsync();
        }
    }
}
