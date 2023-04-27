using FleetFlow.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FleetFlow.Service.Services;

public class AuthService : IAuthService
{
    private IUserService userService;
    private IConfiguration configuration;

    public AuthService(IUserService userService, IConfiguration configuration)
    {
        this.userService = userService;
        this.configuration = configuration;
    }

    public async Task<string> GenerateTokenAsync(string email, string password)
    {
        var user = await userService.CheckUserAsync(email, password);

        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenKey = Encoding.UTF8.GetBytes(configuration["JWT:Key"]);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
             new Claim("Id", user.Id.ToString()),
             new Claim(ClaimTypes.Role, user.Role.ToString()),
             new Claim(ClaimTypes.Name, user.FirstName)
            }),
            IssuedAt = DateTime.UtcNow,
            Expires = DateTime.UtcNow.AddSeconds(20),
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}