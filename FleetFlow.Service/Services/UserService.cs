using FleetFlow.DAL.IRepositories;
using FleetFlow.DAL.Repositories;
using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<User> AddAsync(User user)
        {
            // check for exist user
            var existUser = await unitOfWork.Users
                .SelectAsync(p => p.Phone == user.Phone);
            
            if (existUser != null)
            {
                throw new Exception("User already exist");
            }

            var result = await unitOfWork.Users.InsertAsync(user);

            await unitOfWork.SaveChangesAsync();

            return result;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            var users = await unitOfWork.Users.SelectAll()
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
    }
}
