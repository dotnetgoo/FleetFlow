using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Entities.Attachments;
using FleetFlow.Service.DTOs.Attachments;
using FleetFlow.Service.Interfaces.Attachments;
using FleetFlow.Shared.Helpers;
using Path = System.IO.Path;

namespace FleetFlow.Service.Services.Attachments;

public class AttachmentService : IAttachmentService
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

    public async ValueTask<Attachment> UploadAsync(AttachmentCreationDto dto)
    {
        // combining paths and create if not exists
        string path = Path.Combine(EnvironmentHelper.WebRootPath, "Files", "Payments");
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);

        string fileName = $"{Guid.NewGuid()}{dto.FileExtension}";
        string fullPath = Path.Combine(path, fileName);

        // creating file in created or existed folder and write all content
        FileStream targetFile = new FileStream(fullPath, FileMode.OpenOrCreate);
        await targetFile.WriteAsync(dto.File);

        Attachment attachment = new Attachment
        {
            FileName = fileName,
            FilePath = fullPath,
            CreatedAt = DateTime.UtcNow,
        };
        return await attachmentRepository.InsertAsync(attachment);
    }
}
