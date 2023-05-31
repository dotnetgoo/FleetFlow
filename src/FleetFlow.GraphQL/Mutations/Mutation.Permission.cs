using FleetFlow.Service.DTOs.Permissions;
using FleetFlow.Service.Interfaces.Authorizations;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<PermissionForResultDto> CreatePermissionAsync([Service] IPermissionService permissionService, PermissionForCreationDto dto)
        {
            return await permissionService.CreateAsync(dto);
        }

        public async ValueTask<bool> DeletePermissionAsync([Service] IPermissionService permissionService, long id)
        {
            var result = await permissionService.RemoveAsync(id);
            if (result)
                return true;
            return false;
        }

        public async ValueTask<PermissionForResultDto> UpdatePermissionAsync([Service] IPermissionService permissionService, PermissionForUpdateDto dto)
        {
            return await permissionService.ModifyAsync(dto);
        }
    }
}
