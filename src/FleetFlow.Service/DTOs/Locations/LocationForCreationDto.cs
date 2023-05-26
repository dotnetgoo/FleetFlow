using FleetFlow.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Service.DTOs.Location
{
    public class LocationForCreationDto
    {
        [Required(ErrorMessage = "Code is required")]
        public long Code { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Type is required")]
        public LocationType Type { get; set; }
    }
}
