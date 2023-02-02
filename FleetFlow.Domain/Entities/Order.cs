using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Domain.Entities
{
    public class Order : Auditable
    {
        public long UserId { get; set; }
        public long AddressId { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
