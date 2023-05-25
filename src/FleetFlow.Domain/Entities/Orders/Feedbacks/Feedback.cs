using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Enums;

namespace FleetFlow.Domain.Entities.Orders.Feedbacks;

public class Feedback : Auditable
{
    public string Message { get; set; }
    public long OrderId { get; set; }
    public Order Order { get; set; }
    public FeedbackStatus Status { get; set; } = FeedbackStatus.NotSeen;

    public ICollection<FeedbackAttachment> Attachments { get; set; }
}
