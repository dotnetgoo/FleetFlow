using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.Interfaces.Commons;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<RegionResultDto> GetRegionByIdAsync([Service] IRegionService service, long id)
        {
            return await service.RetrieveAsync(id);
        }
        public async ValueTask<IEnumerable<RegionResultDto>> GetRegionAllAsync([Service] IRegionService service, PaginationParams @params)
        {
            return await service.RetrieveAllAsync(@params);
        }
    }
}
