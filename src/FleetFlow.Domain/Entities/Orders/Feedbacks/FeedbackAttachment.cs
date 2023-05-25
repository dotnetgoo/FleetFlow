using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Entities.Attachments;

namespace FleetFlow.Domain.Entities.Orders.Feedbacks;

public class FeedbackAttachment : Auditable
{
    public long FeedbackId { get; set; }
    public Feedback Feedback { get; set; }

    public long AttachmentId { get; set; }
    public Attachment Attachment { get; set; }
}
