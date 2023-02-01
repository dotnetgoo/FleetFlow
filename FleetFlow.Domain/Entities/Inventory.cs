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
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public int LocationId { get; set; }
        public int MerchantId { get; set; }
    }
}
