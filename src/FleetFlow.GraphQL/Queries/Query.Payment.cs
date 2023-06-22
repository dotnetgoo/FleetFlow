using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Payments;
using FleetFlow.Service.Interfaces.Orders;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<PaymentResultDto> GetPaymentByIdAsync([Service] IPaymentService service, long id)
        {
            return await service.RetrieveByIdAsync(id);
        }
        public async ValueTask<IEnumerable<PaymentResultDto>> GetPaymentAllAsync([Service] IPaymentService service, PaginationParams @params)
        {
            return await service.RetrieveAllAsync(@params);
        }
    }
}
