using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs.Product;

namespace FleetFlow.Service.DTOs.Carts;

public class CartItemResultDto
{
    public long Id { get; set; }
    public long CartId { get; set; }
    public ProductForResultDto Product { get; set; }
    public int Amount { get; set; }
}
