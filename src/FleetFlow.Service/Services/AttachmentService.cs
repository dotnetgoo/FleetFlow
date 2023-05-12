using FleetFlow.Domain.Entities;
using FleetFlow.Service.Interfaces;
using Microsoft.AspNetCore.Http;

namespace FleetFlow.Service.Services;

public class AttachmentService : IAttachmantService
{
    public ValueTask<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Attachment> UploadAsync(IFormFile file)
    {
        throw new NotImplementedException();
    }
}
