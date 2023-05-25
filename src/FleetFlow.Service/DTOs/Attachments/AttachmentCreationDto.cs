namespace FleetFlow.Service.DTOs.Attachments
{
    public class AttachmentCreationDto
    {
        public byte[] File { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
    }
}
