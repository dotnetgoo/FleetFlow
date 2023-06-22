using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Permissions;
using FleetFlow.Service.Interfaces.Authorizations;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<PermissionForResultDto> GetPermissionByIdAsync([Service] IPermissionService permissionService, long id)
        {
            return await permissionService.RetrieveByIdAsync(id);
        }

        public async ValueTask<IEnumerable<PermissionForResultDto>> GetAllPermissionsAsync([Service] IPermissionService permissionService,
            PaginationParams @params)
        {
            return await permissionService.RetrieveAllAsync(@params);
        }
    }
}
