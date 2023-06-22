using FleetFlow.Service.DTOs.Permissions;
using FleetFlow.Service.DTOs.Roles;

namespace FleetFlow.Service.DTOs.RolePermissions;

public class RolePermissionForResultDto
{
    public long Id { get; set; }
    public long RoleId { get; set; }
    public RoleResultDto Role { get; set; }

    public long PermissonId { get; set; }
    public PermissionForResultDto Permisson { get; set; }
}
