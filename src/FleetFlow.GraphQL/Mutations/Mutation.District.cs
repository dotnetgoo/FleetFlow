using FleetFlow.Service.Interfaces.Commons;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask CreateDistrictAsync([Service] IDistrictService service)
        {
            await service.SaveToDatabase();
        }
    }
}
