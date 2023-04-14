using FleetFlow.Domain.Commons;

namespace FleetFlow.Domain.Entities
{
    public class OrderItem : Auditable
    {
        public long OrderId { get; set; }
        public Order Order { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }

        public int Amount { get; set; }

        public long InventoryId { get; set; }
        public Inventory Inventory { get; set; }
    }
}
