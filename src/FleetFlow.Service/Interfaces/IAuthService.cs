using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs.Login;

namespace FleetFlow.Service.Interfaces;

public interface IAuthService
{
    Task<LoginResultDto> AuthenticateAsync(string email, string password);
}