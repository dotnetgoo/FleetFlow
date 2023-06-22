using FleetFlow.Service.DTOs.Roles;
using FleetFlow.Service.Interfaces.Authorizations;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<RoleResultDto> CreateRoleAsync([Service] IRoleService roleService, RoleCreationDto dto)
        {
            return await roleService.AddAsync(dto);
        }
        public async ValueTask<bool> DeleteRoleAsync([Service] IRoleService roleService, long id)
        {
            var result = await roleService.RemoveAsync(id);
            if (result)
                return true;
            return false;
        }

        public async ValueTask<bool> UpdateRoleAsync([Service] IRoleService roleService, RoleUpdateDto dto)
        {
            return await roleService.ModifyAsync(dto);
        }

    }
}
