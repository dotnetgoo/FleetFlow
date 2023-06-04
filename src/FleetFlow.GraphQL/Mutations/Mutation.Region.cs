using FleetFlow.Service.Interfaces.Commons;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask CreateRegionAsync([Service] IRegionService service)
        {
            await service.SaveToDatabase();
        }
    }
}
