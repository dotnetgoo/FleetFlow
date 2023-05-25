using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Enums;

namespace FleetFlow.Domain.Entities.Warehouses
{
    public class Location : Auditable
    {
        public long Type { get; set; }
        public LocationType locationType { get; set; }
        public long Code { get; set; }
        public string Description { get; set; }
    }
}
