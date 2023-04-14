using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces;
using MailKit.Net.Imap;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace FleetFlow.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public UserService(IUnitOfWork unitOfWork , IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<UserForResultDto> AddAsync(UserForCreationDto dto)
        {
            // check for exist user
            var existUser = await unitOfWork.Users
                .SelectAsync(p => p.Phone == dto.Phone);            
            if (existUser != null)
            {
                throw new FleetFlowException(400,"User already exist");
            }

            var mapped = this.mapper.Map<User>(dto);
            mapped.CreatedAt = DateTime.UtcNow;

            var result = await unitOfWork.Users.InsertAsync(mapped);

            var temp = this.mapper.Map<UserForResultDto>(result);
            await unitOfWork.SaveChangesAsync();

            return temp;
        }

        public async Task<bool> DeleteAsync(Expression<Func<User, bool>> predicate)
        {
            var user = await this.unitOfWork.Users.SelectAsync(predicate);
            if (user is null) throw new FleetFlowException(404, "Couldn't find user for this given Id");

            bool IsDeleted = await this.unitOfWork.Users.DeleteAsync(predicate);
            await this.unitOfWork.SaveChangesAsync();

            return IsDeleted;
        }

        public async Task<IEnumerable<User>> GetAllAsync(PaginationParams @params)
        {
            var users = await unitOfWork.Users.SelectAll()
                .ToPagedList(@params)
                .ToListAsync();

            return users;
        }

        public async Task<IEnumerable<User>> GetAllByRoleAsync(UserRole role = UserRole.Admin)
        {
            var users = await unitOfWork.Users.SelectAll()
                .Where(u => u.Role == role)
                .ToListAsync();

            return users;
        }

        public async Task<UserForResultDto> GetAsync(Expression<Func<User, bool>> expression)
        {
            var user = await this.unitOfWork.Users.SelectAsync(expression);

            if (user is null)
                throw new FleetFlowException(404, "User Not Found");

            var mapped = this.mapper.Map<UserForResultDto>(user);

            return mapped;
        }

        public async Task<UserForResultDto> UpdateAsync(Expression<Func<User, bool>> expression, UserForCreationDto dto)
        {
            var user = await this.unitOfWork.Users.SelectAsync(expression);
            if (user is null)
                throw new FleetFlowException(404, "Couldn't found user for given Id");

            user.Phone = dto.Phone;
            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;
            user.Email = dto.Email;
            user.UpdatedAt = DateTime.UtcNow;

            var result = this.mapper.Map<UserForResultDto>(user);
            await this.unitOfWork.SaveChangesAsync();

            return result;
        }
    }
}
