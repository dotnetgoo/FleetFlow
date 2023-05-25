using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs.Attachments;

namespace FleetFlow.Service.Interfaces;

public interface IAttachmentService
{
    ValueTask<Attachment> UploadAsync(AttachmentCreationDto dto);
    ValueTask<bool> DeleteAsync(long id);
}
