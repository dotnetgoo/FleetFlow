using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Entities.Products;
using FleetFlow.Domain.Enums;

namespace FleetFlow.Domain.Entities.Bonuses;

public class BonusSetting : Auditable
{
    public BonusType Type { get; set; }
    public string PromoCode { get; set; }
    public bool IsPromoCodeUsed { get; set; }
    public decimal? AmountFrom { get; set; }
    public decimal? AmountTo { get; set; }
    public decimal? Amount { get; set; }
    public long? ProductId { get; set; }
    public Product Product { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}