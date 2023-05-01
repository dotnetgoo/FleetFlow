using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Enums;

namespace FleetFlow.Domain.Entities
{
    public class Order : Auditable
    {
        public long UserId { get; set; }
        public User User { get; set; }
        public long AddressId { get; set; }
        public Address Address { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public PaymentStatus PaymentStatus { get; set; }
        
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
