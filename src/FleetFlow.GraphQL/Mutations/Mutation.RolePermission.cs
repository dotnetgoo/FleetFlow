using FleetFlow.Service.DTOs.RolePermissions;
using FleetFlow.Service.Interfaces.Authorizations;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<RolePermissionForResultDto> CreateRolePermissionAsync([Service] IRolePermissionService rolePermissionService, RolePermissionForCreateDto dto)
        {
            return await rolePermissionService.CreateAsync(dto);
        }

        public async ValueTask<bool> DeleteRolePermissionAsync([Service] IRolePermissionService rolePermissionService, long id)
        {

            var result = await rolePermissionService.RemoveAsync(id);
            if (result)

                return true;
            return false;
        }

        public async ValueTask<RolePermissionForResultDto> UpdateRolePermissionAsync([Service] IRolePermissionService rolePermissionService, RolePermissionForUpdateDto dto)
        {
            return await rolePermissionService.ModifyAsync(dto);
        }
    }
}
