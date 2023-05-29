using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.StaffPermissions;

namespace FleetFlow.Service.Interfaces.StaffPermissions
{
    internal interface IStaffPermissionService
    {
        Task<StaffPermissionForResultDto> AddPermission(StaffPermissionsForCreationDto dto);
        Task<bool> RemovePermission(StaffPermissionsForCreationDto dto);
        Task<IEnumerable<StaffPermissionForResultDto>> GetStaffsAllPermissions(PaginationParams @params, long staffId);
    }
}
