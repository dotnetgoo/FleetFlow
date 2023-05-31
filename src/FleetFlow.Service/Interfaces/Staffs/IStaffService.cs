using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Staffs;

namespace FleetFlow.Service.Interfaces.Staffs
{
    public interface IStaffService
    {
        Task<StaffForResultDto> AddAsync(StaffForCreationDto dto);
        Task<StaffForResultDto> RetrieveByIdAsync(long id);
        Task<StaffForResultDto> RetrieveByUserIdAsync(long UserId);
        Task<IEnumerable<StaffForResultDto>> RetrieveAllAsync(PaginationParams @params);
        Task<IEnumerable<StaffForResultDto>> RetrieveAllByRoleAsync(PaginationParams @params, long RoleId);
        Task<bool> RemoveAsync(long Id);
        //Task<StaffForResultDto> AddPermissionAsync(long staffId, long permissionId);
        //Task<StaffForResultDto> RemovePermissionAsync(long staffId, long permissionId);
        Task<StaffForResultDto> ModifyAsync(long id, StaffForUpdateDto dto);

    }
}
