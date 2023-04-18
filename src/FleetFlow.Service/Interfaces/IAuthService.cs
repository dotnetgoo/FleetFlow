using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FleetFlow.Service.DTOs;

namespace FleetFlow.Service.Interfaces
{
    public interface IAuthService
    {
        ValueTask<UserForResultDto> AuthenticateAsync(UserForLoginDto dto);
    }
}