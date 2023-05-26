using FleetFlow.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Domain.Configurations
{
    public class Filter
    {
        public long? ProductId { get; set; }
        public long? OwnerId { get; set; }
        public InventoryLogType Type { get; set; }
    }
}
