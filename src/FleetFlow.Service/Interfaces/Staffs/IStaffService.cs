using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Staffs;

namespace FleetFlow.Service.Interfaces.Staffs
{
    public interface IStaffService
    {
        Task<StaffForResultDto> AddAsync(StaffForCreationDto dto);
        Task<StaffForResultDto> RetrieveByIdAsync(long id);
        Task<StaffForResultDto> RetrieveByUserIdAsync(long UserId);
        Task<IEnumerable<StaffForResultDto>> RetrieveAllAsync(PaginationParams @params = null);
        Task<IEnumerable<StaffForResultDto>> RetrieveAllByRoleAsync(long RoleId, PaginationParams @params = null);
        Task<bool> RemoveAsync(long Id);
        Task<StaffForResultDto> ModifyAsync(long id, StaffForUpdateDto dto);

    }
}
