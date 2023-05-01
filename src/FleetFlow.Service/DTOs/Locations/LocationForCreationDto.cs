using FleetFlow.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Service.DTOs.Location
{
    public class LocationForCreationDto
    {
        [Required(ErrorMessage = "Location code is required")]
        public string Code { get; set; }
        public string Description { get; set; }
        public LocationType Type { get; set; }
    }
}
