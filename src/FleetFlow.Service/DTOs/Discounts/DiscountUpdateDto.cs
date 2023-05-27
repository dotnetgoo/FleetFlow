namespace FleetFlow.Service.DTOs.Discounts
{
    public class DiscountUpdateDto
    {
        public long ProductId { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime? FinishedAt { get; set; }
        public decimal PercentageToCheapen { get; set; }
    }
}
