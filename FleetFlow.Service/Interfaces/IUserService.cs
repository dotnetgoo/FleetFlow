using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.Interfaces
{
    public interface IUserService
    {
        Task<User> AddAsync(User user);
        Task<IEnumerable<User>> GetAllAsync(PaginationParams @params);
        Task<IEnumerable<User>> GetAllByRoleAsync(UserRole role = UserRole.Admin);
    }
}
