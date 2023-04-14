using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.Interfaces
{
    public interface IUserService
    {
        Task<UserForResultDto> AddAsync(UserForCreationDto dto);
        Task<IEnumerable<User>> GetAllAsync(PaginationParams @params);
        Task<IEnumerable<User>> GetAllByRoleAsync(UserRole role = UserRole.Admin);
        Task<bool> DeleteAsync(Expression<Func<User, bool>> predicate);
        Task<UserForResultDto> GetAsync(Expression<Func<User, bool>> expression);
        Task<UserForResultDto> UpdateAsync(Expression<Func<User, bool>> expression, UserForCreationDto dto);
    }
}
