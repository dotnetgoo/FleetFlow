using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Permissions;

namespace FleetFlow.Service.Interfaces.Authorizations;

public interface IPermissionService
{
    Task<bool> RemoveAsync(long id);
    Task<PermissionForResultDto> RetrieveByIdAsync(long id);
    Task<PermissionForResultDto> ModifyAsync(PermissionForUpdateDto dto);
    Task<PermissionForResultDto> CreateAsync(PermissionForCreationDto dto);
    Task<List<PermissionForResultDto>> RetrieveAllAsync(PaginationParams @params);

}
