using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Entities.Products;

namespace FleetFlow.Domain.Entities.Orders
{
    public class OrderItem : Auditable
    {
        public int Amount { get; set; }
        public decimal AmountTotal { get; set; }

        public long OrderId { get; set; }
        public Order Order { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}
