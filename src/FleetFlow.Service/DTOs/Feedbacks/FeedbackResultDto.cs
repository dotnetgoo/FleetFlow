using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Attachments;

namespace FleetFlow.Service.DTOs.Feedbacks
{
    public class FeedbackResultDto
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public string Message { get; set; }
        public FeedbackStatus Status { get; set; }

        public List<AttachmentResultDto> Attachments { get; set; }
    }
}
