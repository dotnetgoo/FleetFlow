using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.Interfaces.Orders;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<AddressForResultDto> AssignAddressAsync([Service] ICheckoutService checkoutService,
            AddressAddDto address)
        {
            return await checkoutService.AssignAddressAsync(address);
        }

        public async ValueTask<AddressForResultDto> RetrieveLastAddressAsync([Service] ICheckoutService checkoutService)
        {
            return await checkoutService.RetrieveLastAddressAsync();
        }
    }
}
