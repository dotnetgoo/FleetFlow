using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Product;

namespace FleetFlow.Service.DTOs.Discounts
{
    public class DiscountResultDto
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public ProductForResultDto Product { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime? FinishedAt { get; set; }
        public decimal Amount { get; set; }
        public decimal PriceInDiscount { get; set; }
        public DiscountState State { get; set; }
    }
}
