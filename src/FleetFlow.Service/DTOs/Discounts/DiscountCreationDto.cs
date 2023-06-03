namespace FleetFlow.Service.DTOs.Discounts;

public class DiscountCreationDto
{
    public long ProductId { get; set; }
    public DateTime StartedAt { get; set; }
    public DateTime? FinishedAt { get; set; }
    public decimal Amount { get; set; }
}
