using FleetFlow.Domain.Commons;

namespace FleetFlow.Domain.Entities.Warehouses
{
    public class Location : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
