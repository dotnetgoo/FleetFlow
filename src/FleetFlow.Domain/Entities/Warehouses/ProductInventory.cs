using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Entities.Products;

namespace FleetFlow.Domain.Entities.Warehouses
{
    public class ProductInventory : Auditable
    {
        public long ProductId { get; set; }
        public Product Product { get; set; }

        public int Amount { get; set; }

        public long LocationId { get; set; }
        public Location Location { get; set; }


        public long InventoryId { get; set; }
        public Inventory Inventory { get; set; }
    }
}
