using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Enums;

namespace FleetFlow.Domain.Entities
{
    public class OrderAction : Auditable
    {
        public long OrderId { get; set; }
        public Order Order { get; set; }
        public OrderStatus Status { get; set; }
    }
}