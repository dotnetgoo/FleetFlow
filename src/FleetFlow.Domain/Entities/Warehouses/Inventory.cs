using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Entities.Addresses;

namespace FleetFlow.Domain.Entities.Warehouses
{
    public class Inventory : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long AddressId { get; set; }
        public Address Address { get; set; }
    }
}
