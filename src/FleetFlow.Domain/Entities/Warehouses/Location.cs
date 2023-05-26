using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Enums;

namespace FleetFlow.Domain.Entities.Warehouses
{
    public class Location : Auditable
    {
        public long Code { get; set; }
        public LocationType Type { get; set; }
        public string Description { get; set; }
    }
}
