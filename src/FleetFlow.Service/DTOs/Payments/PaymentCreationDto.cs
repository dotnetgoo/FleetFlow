namespace FleetFlow.Service.DTOs.Payments;

public class PaymentCreationDto
{
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public long UserId { get; set; }
    public long OrderId { get; set; }
    public bool IsAdmin { get; set; }
}