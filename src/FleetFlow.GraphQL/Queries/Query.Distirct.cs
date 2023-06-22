using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.Interfaces.Commons;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<DistrictResultDto> GetDistirctByIdAsync([Service] IDistrictService service, long id)
        {
            return await service.RetrieveAsync(id);
        }
        public async ValueTask<IEnumerable<DistrictResultDto>> GetDistrictAllAsync([Service] IDistrictService service, PaginationParams @params)
        {
            return await service.RetrieveAllAsync(@params);
        }
    }

}
