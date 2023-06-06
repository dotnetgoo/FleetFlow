using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.DTOs.User;

namespace FleetFlow.Service.DTOs.Inventories
{
    public class InventoryForResultDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public long RegionId { get; set; }
        public RegionResultDto Region { get; set; }

        public long DistrictId { get; set; }
        public DistrictResultDto District { get; set; }

        public long AddressId { get; set; }
        public AddressForResultDto Address { get; set; }

        public long? OwnerId { get; set; }
        public UserForResultDto Owner { get; set; }
    }
}
