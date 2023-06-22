using FleetFlow.Service.DTOs.Login;
using FleetFlow.Service.Interfaces.Users;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<LoginResultDto> AuthenticateAsync([Service] IAuthService authService,
            string email,
            string password)
        {
            return await authService.AuthenticateAsync(email, password);
        }
    }
}
