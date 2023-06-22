using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Service.DTOs.User;
using FleetFlow.Service.Interfaces.Users;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<UserForResultDto> GetUserByIdAsync([Service] IUserService service, long id)
        {
            return await service.RetrieveByIdAsync(id);
        }
        public async ValueTask<IEnumerable<UserForResultDto>> GetUserAllAsync([Service] IUserService service, PaginationParams @params)
        {
            return await service.RetrieveAllAsync(@params);
        }
        public async ValueTask<IEnumerable<UserForResultDto>> GetUserByPhoneAsync([Service] IUserService service, PaginationParams @params,
            long roleId)
        {
            return await service.RetrieveAllByRoleAsync(@params, roleId);
        }
        public async ValueTask<User> GetUserByEmailAsync([Service] IUserService service, string email)
        {
            return await service.RetrieveByEmailAsync(email);
        }
    }
}
