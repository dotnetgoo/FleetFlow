using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Authorizations;
using FleetFlow.Service.DTOs.RolePermissions;
using System.Linq.Expressions;

namespace FleetFlow.Service.Interfaces.Authorizations;

public interface IRolePermissionService
{
	Task<RolePermissionForResultDto> CreateAsync(RolePermissionForCreateDto permission);
	Task<RolePermissionForResultDto> ModifyAsync(RolePermissionForUpdateDto permission);
	Task<bool> RemoveAsync(long id);
	Task<RolePermissionForResultDto> RetrieveByIdAsync(long id);
	Task<List<RolePermissionForResultDto>> RetrieveAllAsync(PaginationParams @params);
	Task<bool> CheckPermission(string role, string accessedMethod); 
}
