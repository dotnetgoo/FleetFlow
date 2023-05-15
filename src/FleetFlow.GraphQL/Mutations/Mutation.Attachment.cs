using FleetFlow.Domain.Entities;
using FleetFlow.Service.Interfaces;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<Attachment> UploadImageAsync([Service] IAttachmantService attachmantService,
            IFormFile file)
        {
            return await attachmantService.UploadAsync(file);
        }

        public async ValueTask<bool> DeleteAsync([Service] IAttachmantService attachmantService,
            long id)
        {
            return await attachmantService.DeleteAsync(id);
        }
    }
}
