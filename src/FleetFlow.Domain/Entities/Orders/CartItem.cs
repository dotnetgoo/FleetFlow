using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Entities.Products;
using FleetFlow.Domain.Entities.Warehouses;

namespace FleetFlow.Domain.Entities;

public class CartItem : Auditable
{
    public long CartId { get; set; }
    public Cart Cart { get; set; }

    public long ProductId { get; set; }
    public Product Product { get; set; }

    public long ProductInventoryAssignmentId { get; set; }
    public ProductInventoryAssignment productInventoryAssignment { get; set; }

    public int Amount { get; set; }
}
