using FleetFlow.Domain.Commons;

namespace FleetFlow.Domain.Entities.Orders.Feedbacks;

public class Feedback : Auditable
{
    public string Message { get; set; }
    public long OrderId { get; set; }
    public Order Order { get; set; }

    public ICollection<FeedbackAttachment> Attachments { get; set; }
}
