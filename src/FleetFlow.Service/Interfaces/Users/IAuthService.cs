using FleetFlow.Service.DTOs.Login;

namespace FleetFlow.Service.Interfaces.Users;

public interface IAuthService
{
    Task<LoginResultDto> AuthenticateAsync(string email, string password);
}