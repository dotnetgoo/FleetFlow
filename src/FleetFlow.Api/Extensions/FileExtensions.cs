using FleetFlow.Service.DTOs.Attachments;

namespace FleetFlow.Api.Extensions
{
    public static class FileExtensions
    {
        public async static Task<AttachmentCreationDto> ToAttachmentAsync(this IFormFile file)
        {
            // decleration
            byte[] bytes;
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                bytes = memoryStream.ToArray();
            }
            return new AttachmentCreationDto
            {
                File = bytes,
                FileName = file.FileName,
                FileExtension = Path.GetExtension(file.FileName)
            };
        }
    }
}
