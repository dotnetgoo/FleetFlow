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
        public Order Order { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public long InventoryId { get; set; }
        public Inventory Inventory { get; set; }
    }
}
