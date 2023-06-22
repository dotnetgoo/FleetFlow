using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.RolePermissions;
using FleetFlow.Service.Interfaces.Authorizations;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<RolePermissionForResultDto> GetRolePermissionByIdAsync([Service] IRolePermissionService rolePermissionService, long id)
        {
            return await rolePermissionService.RetrieveByIdAsync(id);
        }

        public async ValueTask<IEnumerable<RolePermissionForResultDto>> GetAllPermissionsAsync([Service] IRolePermissionService rolePermissionService,
            PaginationParams @params)
        {
            return await rolePermissionService.RetrieveAllAsync(@params);
        }
    }
}
