using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Service.DTOs.Staffs
{
    public class StaffForCreationDto
    {
        [Required(ErrorMessage = "UserId is required")]
        public long UserId { get; set; }

        [Required(ErrorMessage = "RoleId is required")]
        public long RoleId { get; set; }
    }
}
