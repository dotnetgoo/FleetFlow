using FleetFlow.DAL.IRepositories;
using FleetFlow.DAL.Repositories;
using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.Interfaces;
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
        private readonly IRepository<User> userRepository;

        public UserService(IRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<User> AddAsync(User user)
        {
            // check for exist user
            var existUser = await userRepository
                .SelectAsync(p => p.Phone == user.Phone);
            
            if (existUser != null)
            {
                throw new Exception("User already exist");
            }

            return await userRepository.InsertAsync(user);
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            var users = userRepository.SelectAllAsync();

            return users;
        }

        public Task<IEnumerable<User>> GetAllByRoleAsync(UserRole role = UserRole.Admin)
        {
            var users = userRepository.SelectAllAsync(u => u.Role == role);

            return users;
        }
    }
}
