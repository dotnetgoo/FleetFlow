using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

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
    }
}
