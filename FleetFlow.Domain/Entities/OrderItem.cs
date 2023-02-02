using FleetFlow.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Domain.Entities
{
    public class OrderItem : Auditable
    {
        public long OrderId { get; set; }
        public long ProductId { get; set; }
        public int Amount { get; set; }
        public long InventoryId { get; set; }
    }
}
