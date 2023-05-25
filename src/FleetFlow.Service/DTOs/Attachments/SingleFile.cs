using Microsoft.AspNetCore.Http;

namespace FleetFlow.Service.DTOs.Attachments
{
    public class SingleFile
    {
        public IFormFile File { get; set; }
    }
}
