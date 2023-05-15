using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.Interfaces;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<OrderResultDto> CreateAsync([Service] IOrderService orderService)
        {
            return await orderService.AddAsync();
        }
    }
}
