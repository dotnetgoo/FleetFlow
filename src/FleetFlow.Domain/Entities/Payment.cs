using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Enums;
using System.Security.Cryptography.X509Certificates;

namespace FleetFlow.Domain.Entities;

public class Payment : Auditable
{
    public decimal? Amount { get; set; }
    public string Description { get; set; }
    public PaymentStatus Status { get; set; }
 
    public long UserId { get; set; }
    public User User { get; set; }
    
    public long OrderId { get; set; }
    public Order Order { get; set; }
    
    public long FileId { get; set; }
    public Attachment File { get; set; }
}
