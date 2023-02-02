using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Domain.Entities
{
    public class Inventory : Auditable
    {
        public long ProductId { get; set; }
        public int Amount { get; set; }
        public long LocationId { get; set; }
        public long MerchantId { get; set; }
    }
}
