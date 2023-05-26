using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Staffs;
using FleetFlow.Service.DTOs.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
