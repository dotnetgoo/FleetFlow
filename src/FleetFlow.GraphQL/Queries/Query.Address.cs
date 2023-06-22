using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.Interfaces.Addresses;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<AddressForResultDto> GetAddressByIdAsync([Service] IAddressService service, long id)
        {
            return await service.GetByIdAsync(id);
        }
        public async ValueTask<IEnumerable<AddressForResultDto>> GetAdressAll([Service] IAddressService service, PaginationParams @params)
        {
            return await service.GetAllAsync(@params);
        }
    }
}
