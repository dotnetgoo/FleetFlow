using FleetFlow.Domain.Entities.Users;
using FleetFlow.Service.DTOs.Login;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Interfaces.Authorizations;
using FleetFlow.Service.Interfaces.Users;
using FleetFlow.Shared.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FleetFlow.Service.Services.Users;

public class AuthService : IAuthService
{
    private readonly IUserService userService;
    private readonly IConfiguration configuration;
    private readonly IRoleService roleService;

    public AuthService(IUserService userService, IConfiguration configuration, IRoleService roleService)
    {
        this.userService = userService;
        this.configuration = configuration;
        this.roleService = roleService;
    }

    public async Task<LoginResultDto> AuthenticateAsync(string email, string password)
    {
        var user = await userService.RetrieveByEmailAsync(email);
        if (user == null || !PasswordHelper.Verify(password, user.Password))
            throw new FleetFlowException(400, "Email or password is incorrect");

        var role = await this.roleService.RetrieveByIdForAuthAsync(user.RoleId);
        user.Role = role;
        return new LoginResultDto
        {
            Token = GenerateToken(user)
        };
    }

    private string GenerateToken(User user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenKey = Encoding.UTF8.GetBytes(configuration["JWT:Key"]);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                 new Claim("Id", user.Id.ToString()),
                 new Claim(ClaimTypes.Role, user.Role.Name.ToString()),
                 new Claim(ClaimTypes.Name, user.FirstName)
            }),
            Audience = configuration["JWT:Audience"],
            Issuer = configuration["JWT:Issuer"],
            IssuedAt = DateTime.UtcNow,
            Expires = DateTime.UtcNow.AddMinutes(double.Parse(configuration["JWT:Expire"])),
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}