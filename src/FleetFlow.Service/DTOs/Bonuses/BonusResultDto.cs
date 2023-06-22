using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.DTOs.Product;
using FleetFlow.Service.DTOs.User;

namespace FleetFlow.Service.DTOs.Bonuses;

public class BonusResultDto
{
    public long Id { get; set; }
    public decimal? Amount { get; set; }
    public BonusType Type { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal? OrderCashBack { get; set; }
    public UserForResultDto User { get; set; }
    public OrderItemForResultDto Order { get; set; }
    public ProductForResultDto Product { get; set; }
}