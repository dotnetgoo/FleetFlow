using FleetFlow.Service.DTOs.User;
using FleetFlow.Service.Interfaces.Users;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<UserForResultDto> CreateUserAsync([Service] IUserService userService,
            UserForCreationDto user)
        {
            return await userService.AddAsync(user);
        }

        public async ValueTask<bool> DeleteUserAsync([Service] IUserService userService,
            long id)
        {
            return await userService.RemoveAsync(id);
        }

        public async ValueTask<UserForResultDto> UpdateUserAsync([Service] IUserService userService,
            long id,
            UserForUpdateDto user)
        {
            return await userService.ModifyAsync(id, user);
        }
    }
}