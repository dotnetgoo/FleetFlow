using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.Interfaces.Orders;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<AddressForResultDto> GetLastAddressAsync([Service] ICheckoutService service)
        {
            return await service.RetrieveLastAddressAsync();
        }
    }
}
