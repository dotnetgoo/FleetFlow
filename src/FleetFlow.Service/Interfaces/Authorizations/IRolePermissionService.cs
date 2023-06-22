using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.RolePermissions;

namespace FleetFlow.Service.Interfaces.Authorizations;

public interface IRolePermissionService
{
    Task<bool> RemoveAsync(long id);
    Task<RolePermissionForResultDto> RetrieveByIdAsync(long id);
    Task<bool> CheckPermission(string role, string accessedMethod);
    Task<List<RolePermissionForResultDto>> RetrieveAllAsync(PaginationParams @params);
    Task<RolePermissionForResultDto> ModifyAsync(RolePermissionForUpdateDto permission);
    Task<RolePermissionForResultDto> CreateAsync(RolePermissionForCreateDto permission);
}
