using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.User;
using FleetFlow.Service.Interfaces.Users;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<UserForResultDto> GetUserAsync([Service] IUserService userService,
            long id)
        {
            return await userService.RetrieveByIdAsync(id);
        }

        [UseOffsetPaging(IncludeTotalCount = true)]
        [UseFiltering]
        [UseSorting]
        public async ValueTask<IEnumerable<UserForResultDto>> GetAllUsersAsync([Service] IUserService userService,
            PaginationParams @params)
        {
            var users = await userService.RetrieveAllAsync(@params);

            return users;
        }
    }
}
