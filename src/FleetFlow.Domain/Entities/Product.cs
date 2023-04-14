using FleetFlow.Domain.Commons;

namespace FleetFlow.Domain.Entities
{
    public class Product : Auditable
    {
        public string Name { get; set; }
        public string Serial { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public long CategoryId { get; set; }
        public ProductCategory Category { get; set; }

        public ICollection<Inventory> Inventories { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
