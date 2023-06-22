using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Service.DTOs.Roles
{
    public class RoleUpdateDto
    {
        [Required]
        public long RoleId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
