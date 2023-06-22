using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Entities.Orders;
using FleetFlow.Domain.Entities.Products;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Domain.Enums;

namespace FleetFlow.Domain.Entities.Bonuses;

public class Bonus : Auditable
{
    public decimal? Amount { get; set; }
    public BonusType Type { get; set; }
    public long OrderId { get; set; }
    public Order Order { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal? OrderCashBack { get; set; }
    public long? ProductId { get; set; }
    public Product Product { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
    public string UsedPromoCode { get; set; }
    public bool IsPromoCodeUsed { get; set; }
}
