using FleetFlow.Domain.Entities.Attachments;
using FleetFlow.Service.DTOs.Attachments;

namespace FleetFlow.Service.Interfaces.Attachments;

public interface IAttachmentService
{
    ValueTask<Attachment> UploadAsync(AttachmentCreationDto dto);
    ValueTask<bool> DeleteAsync(long id);
}
