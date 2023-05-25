using FleetFlow.Domain.Entities.Attachments;
using FleetFlow.GraphQL.Extensions;
using FleetFlow.Service.DTOs.Attachments;
using FleetFlow.Service.Interfaces;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<Attachment> UploadImageAsync([Service] IAttachmentService attachmantService,
            IFile file)
        {
            return await attachmantService.UploadAsync(await file.ToAttachmentAsync());
        }

        public async ValueTask<bool> DeleteAsync([Service] IAttachmentService attachmantService,
            long id)
        {
            return await attachmantService.DeleteAsync(id);
        }
    }
}
