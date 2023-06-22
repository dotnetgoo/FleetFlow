using FleetFlow.Service.DTOs.Location;
using FleetFlow.Service.Interfaces.Warehouses;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<LocationForResultDto> CreateLocationAsync([Service] ILocationService locationService,
            LocationForCreationDto location)
        {
            return await locationService.AddAsync(location);
        }

        public async ValueTask<bool> DeleteLocationAsync([Service] ILocationService locationService,
            long id)
        {
            return await locationService.RemoveAsync(id);
        }

        public async ValueTask<LocationForResultDto> UpdateLocationAsync([Service] ILocationService locationService,
            long id,
            LocationForCreationDto location)
        {
            return await locationService.ModifyAsync(id, location);
        }
    }
}
