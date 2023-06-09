using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Authorizations;
using FleetFlow.Service.DTOs.Roles;

namespace FleetFlow.Service.Interfaces.Authorizations
{
    public interface IRoleService
    {
        Task<bool> RemoveAsync(long id);
        Task<bool> ModifyAsync(RoleUpdateDto dto);
        Task<Role> RetrieveByIdForAuthAsync(long id);
        Task<RoleResultDto> RetrieveByIdAsync(long id);
        Task<RoleResultDto> AddAsync(RoleCreationDto dto);
        Task<bool> AssignRoleForUserAsync(long userId, long roleId);
        Task<IEnumerable<RoleResultDto>> RetrieveAllAsync(PaginationParams @params);
    }
}
