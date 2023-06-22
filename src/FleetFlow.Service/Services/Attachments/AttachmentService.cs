using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Entities.Attachments;
using FleetFlow.Service.DTOs.Attachments;
using FleetFlow.Service.Exceptions;
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

    public async ValueTask<bool> DeleteAsync(long id)
    {
        var isDeleted = await this.attachmentRepository.DeleteAsync(a => a.Id == id);
        if (!isDeleted)
            throw new FleetFlowException(404, "Attachment not found");

        return isDeleted;
    }

    public async ValueTask<Attachment> UploadAsync(AttachmentCreationDto dto)
    {
        // combining paths and create if not exists
        string path = Path.Combine(EnvironmentHelper.WebRootPath, "Files");
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
        var insertedFile = await this.attachmentRepository.InsertAsync(attachment);
        await this.attachmentRepository.SaveAsync();

        return insertedFile;
    }
}
