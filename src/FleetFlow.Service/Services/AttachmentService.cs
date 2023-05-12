using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Entities;
using FleetFlow.Shared.Helpers;
using Microsoft.AspNetCore.Http;

namespace FleetFlow.Service.Services;

public class AttachmentService
{
    private readonly IRepository<Attachment> attachmentRepository;
    public AttachmentService(IRepository<Attachment> attachmentRepository)
    {
        this.attachmentRepository = attachmentRepository;
    }

    public ValueTask<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<Attachment> UploadAsync(IFormFile file)
    {
        string path = EnvironmentHelper.WebRootPath;
        string fileExtension = Path.GetExtension(file.FileName);
        string fileName = Guid.NewGuid().ToString("N");
        string fullPath = Path.Combine(path, "files", $"{fileName}{fileExtension}");

        FileStream targetFile = new FileStream(fullPath, FileMode.OpenOrCreate);
        await file.CopyToAsync(targetFile);

        Attachment attachment = new Attachment
        {
            FileName = fileName + fileExtension,
            FilePath = fullPath,
            CreatedAt = DateTime.UtcNow,
        };
        return await this.attachmentRepository.InsertAsync(attachment);
    }
}
