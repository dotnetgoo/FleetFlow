using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Product;

namespace FleetFlow.Service.DTOs.Bonuses;

public class BonusSettingResultDto
{
    public long Id { get; set; }
    public BonusType Type { get; set; }
    public bool IsPromoCodeUsed { get; set; }
    public string PromoCode { get; set; }
    public decimal? AmountFrom { get; set; }
    public decimal? AmountTo { get; set; }
    public decimal? Amount { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public ProductForResultDto Product { get; set; }
}