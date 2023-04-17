using FleetFlow.Domain.Enums;

namespace FleetFlow.Service.DTOs
{
    public class LocationForCreationDto
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public LocationType Type { get; set; }
    }
}
