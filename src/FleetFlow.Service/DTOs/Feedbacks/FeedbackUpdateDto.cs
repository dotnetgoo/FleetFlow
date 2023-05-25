using FleetFlow.Service.DTOs.Attachments;

namespace FleetFlow.Service.DTOs.Feedbacks;

public class FeedbackUpdateDto
{
    public long OrderId { get; set; }
    public string Message { get; set; }
    public IEnumerable<AttachmentCreationDto> Attachments { get; set; }
}
