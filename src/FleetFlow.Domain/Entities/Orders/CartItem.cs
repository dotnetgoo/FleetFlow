using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Entities.Products;

namespace FleetFlow.Domain.Entities;

public class CartItem : Auditable
{
    public long CartId { get; set; }
    public Cart Cart { get; set; }

    public long ProductId { get; set; }
    public Product Product { get; set; }

    public int Amount { get; set; }
    public decimal AmountTotal { get; set; }
    public bool IsOrdered { get; set; }
}
