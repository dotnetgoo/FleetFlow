using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Roles;
using FleetFlow.Service.Interfaces.Authorizations;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<RoleResultDto> GetRoleByIdAsync([Service] IRoleService roleService, long id)
        {
            throw new Exception();
            // return await roleService.RetrieveByIdAsync(id);
        }

        public async ValueTask<IEnumerable<RoleResultDto>> GetAllRolesAsync([Service] IRoleService roleService,
            PaginationParams @params)
        {
            return await roleService.RetrieveAllAsync(@params);
        }
    }
}
