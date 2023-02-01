using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Domain.Entities
{
    public class Location : Auditable
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public LocationType Type { get; set; }
    }
}
