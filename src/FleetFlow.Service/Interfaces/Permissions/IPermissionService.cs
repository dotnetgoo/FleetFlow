using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Permissions;

namespace FleetFlow.Service.Interfaces.Permissions
{
    public interface IPermissionService
    {
        Task<PermissionForResultDto> AddAsync(PermissionForCreationDto dto);
        Task<PermissionForResultDto> GetByIdAsync(long permissionId);
        Task<IEnumerable<PermissionForResultDto>> GetAllAsync(PaginationParams @params);
        Task<IEnumerable<PermissionForResultDto>> GetAllByRoleAsync(PaginationParams @params, long RoleId);
        Task<bool> RemoveAsync(long permissionId);
        Task<PermissionForResultDto> ModifyAsync(PermissionForUpdateDto dto);
    }
}
