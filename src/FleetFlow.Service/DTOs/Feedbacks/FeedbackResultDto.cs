using FleetFlow.Service.DTOs.Attachments;

namespace FleetFlow.Service.DTOs.Feedbacks
{
    public class FeedbackResultDto
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public string Message { get; set; }
        public IEnumerable<AttachmentResultDto> Attachments { get; set; }
    }
}
