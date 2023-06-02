using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Entities.Addresses;
using FleetFlow.Domain.Entities.Users;

namespace FleetFlow.Domain.Entities.Warehouses
{
    public class Inventory : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public long? OwnerId { get; set; }
        public User Owner { get; set; }

        public long AddressId { get; set; }
        public Address Address { get; set; }

        public long RegionId { get; set; }
        public Region Region { get; set; }

        public long DistrictId { get; set; }
        public District District { get; set; }
    }
}
