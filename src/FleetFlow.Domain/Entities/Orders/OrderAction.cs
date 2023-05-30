using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Enums;

namespace FleetFlow.Domain.Entities.Orders
{
    public class OrderAction : Auditable
    {
        public long OrderId { get; set; }
        public Order Order { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime? ApproximateFinishTime { get; set; }
    }
}