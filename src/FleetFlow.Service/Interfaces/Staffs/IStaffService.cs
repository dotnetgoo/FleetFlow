using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Staffs;

namespace FleetFlow.Service.Interfaces.Staffs
{
    public interface IStaffService
    {
        Task<StaffForResultDto> AddAsync(StaffForCreationDto dto);
        Task<StaffForResultDto> GetByIdAsync(long staffId);
        Task<IEnumerable<StaffForResultDto>> GetAllAsync(PaginationParams @params);
        Task<IEnumerable<StaffForResultDto>> GetAllByRoleAsync(PaginationParams @params, long RoleId);
        Task<bool> RemoveAsync(long staffId);
        Task<StaffForResultDto> ModifyByRoleAsync(StaffForUpdateRoleDto roleId);
        Task<StaffForResultDto> ModifyByPermissionAsync(StaffForUpdatePermissionDto permissionDto);
        Task<StaffForResultDto> ModifyAsync(StaffForUpdateDto dto);

    }
}
