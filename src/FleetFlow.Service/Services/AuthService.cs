using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Service.DTOs;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Interfaces;

namespace FleetFlow.Service.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public AuthService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async ValueTask<UserForResultDto> AuthenticateAsync(UserForLoginDto dto)
        {
            // check for exist
            var user = await this.unitOfWork.Users.SelectAsync(u => u.Email.ToLower() == dto.Email.ToLower());
            if(user is null)
                throw new FleetFlowException(400, "Email or password is wrong");

            if(user.PasswordHash != dto.Password)
                throw new FleetFlowException(400, "Email or password is wrong");

            return this.mapper.Map<UserForResultDto>(user);
        }
    }
}