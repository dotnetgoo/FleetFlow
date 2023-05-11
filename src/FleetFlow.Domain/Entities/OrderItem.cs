using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Enums;

namespace FleetFlow.Domain.Entities
{
    public class OrderItem : Auditable
    {
        public long OrderId { get; set; }
        public Order Order { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }

        public int Amount { get; set; }
    }
}
