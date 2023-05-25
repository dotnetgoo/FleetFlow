using FleetFlow.Service.DTOs.Attachments;

namespace FleetFlow.Api.Extensions
{
    public static class FileExtensions
    {
        public async static Task<AttachmentCreationDto> ToAttachmentAsync(this IFormFile file)
        {
            using var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);
            byte[] bytes = memoryStream.ToArray();
            
            return new AttachmentCreationDto
            {
                File = bytes,
                FileName = file.FileName,
                FIleExtension = Path.GetExtension(file.FileName)
            };
        }
    }
}
