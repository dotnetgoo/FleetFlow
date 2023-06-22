using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.Interfaces.Addresses;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<AddressForResultDto> CreateAddressAsync([Service] IAddressService addressService,
            AddressForCreationDto address)
        {
            return await addressService.AddAsync(address);
        }

        public async ValueTask<bool> DeleteAddressAsync([Service] IAddressService addressService,
            long id)
        {
            return await addressService.DeleteByIdAsync(id);
        }

        public async ValueTask<AddressForResultDto> UpdateAddressAsync([Service] IAddressService addressService,
            long id,
            AddressForCreationDto address)
        {
            return await addressService.UpdateByIdAsync(id, address);
        }
    }
}
