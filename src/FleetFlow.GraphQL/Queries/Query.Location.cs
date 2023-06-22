using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Location;
using FleetFlow.Service.Interfaces.Warehouses;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<LocationForResultDto> GetLocationByIdAsync([Service] ILocationService service, long id)
        {
            return await service.RetrieveByIdAsync(id);
        }
        public async ValueTask<IEnumerable<LocationForResultDto>> GetLocationAll([Service] ILocationService service, PaginationParams @params)
        {
            return await service.RetrieveAllAsync(@params);
        }
    }
}
