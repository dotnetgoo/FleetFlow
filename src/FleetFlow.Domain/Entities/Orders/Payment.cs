using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Entities.Attachments;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Domain.Enums;

namespace FleetFlow.Domain.Entities.Orders;

public class Payment : Auditable
{
    public decimal? Amount { get; set; }
    public string Description { get; set; }
    public PaymentStatus Status { get; set; }
    public bool IsAdmin { get; set; }

    public long UserId { get; set; }
    public User User { get; set; }

    public long OrderId { get; set; }
    public Order Order { get; set; }

    public long AttachmentId { get; set; }
    public Attachment Attachment { get; set; }
}
