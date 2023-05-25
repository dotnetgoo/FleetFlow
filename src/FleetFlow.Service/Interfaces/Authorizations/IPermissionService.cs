using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Authorizations;
using FleetFlow.Service.DTOs.Permissions;
using System.Linq.Expressions;

namespace FleetFlow.Service.Interfaces.Authorizations;

public interface IPermissionService
{
	Task<PermissionForResultDto> CreateAsync(PermissionForCreationDto dto);
	Task<bool> RemoveAsync(long id);
	Task<PermissionForResultDto> ModifyAsync(PermissionForUpdateDto dto);
	Task<PermissionForResultDto> RetrieveByIdAsync(long id);
	Task<List<PermissionForResultDto>> RetrieveAllAsync(PaginationParams @params);
	
}
