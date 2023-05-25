using FleetFlow.Service.DTOs.Attachments;

namespace FleetFlow.GraphQL.Extensions
{
    public static class FileExtensions
    {
        public async static Task<AttachmentCreationDto> ToAttachmentAsync(this IFile file)
        {
            using var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);
            byte[] uploadedFile = memoryStream.ToArray();

            string fname = file.Name;
            return new AttachmentCreationDto
            {
                File = uploadedFile,
                FileName = file.Name
            };
        }
    }
}
