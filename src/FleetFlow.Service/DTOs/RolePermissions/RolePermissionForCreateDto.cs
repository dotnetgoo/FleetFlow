using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Service.DTOs.RolePermissions;

public class RolePermissionForCreateDto
{
    [Required(ErrorMessage = "RoleId is required")]
    public long RoleId { get; set; }

    [Required(ErrorMessage = "PermissionId is required")]
    public long PermissonId { get; set; }
}
