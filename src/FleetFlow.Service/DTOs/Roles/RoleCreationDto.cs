using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Service.DTOs.Roles
{
    public class RoleCreationDto
    {
        [Required]
        public string Name { get; set; }
    }
}
