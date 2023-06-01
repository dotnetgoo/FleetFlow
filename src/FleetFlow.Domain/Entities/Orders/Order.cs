using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Entities.Addresses;
using FleetFlow.Domain.Entities.Orders.Feedbacks;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Domain.Enums;

namespace FleetFlow.Domain.Entities.Orders
{
    public class Order : Auditable
    {
        public long UserId { get; set; }
        public User User { get; set; }

        public long RegionId { get; set; }
        public Region Region { get; set; }

        public long DistrictId { get; set; }
        public District District { get; set; }

        public long AddressId { get; set; }
        public Address Address { get; set; }

        public long? PaymentId {get; set;}
        public Payment Payment { get; set; }
        public OrderStatus Status { get; set; }
        public PaymentStatus PaymentStatus { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<OrderAction> Actions { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
    }
}
