using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Service.DTOs.Location
{
    public class LocationForCreationDto
    {
        [Required(ErrorMessage = "Location name is required")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
