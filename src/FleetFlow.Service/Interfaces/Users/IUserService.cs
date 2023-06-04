using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Authorizations;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.Interfaces.Users
{
    public interface IUserService
    {
        Task<UserForResultDto> AddAsync(UserForCreationDto dto);
        Task<IEnumerable<UserForResultDto>> RetrieveAllAsync(PaginationParams @params = null);
        Task<IEnumerable<UserForResultDto>> RetrieveAllByRoleAsync(long roleId, PaginationParams @params = null);
        Task<User> RetrieveByEmailAsync(string email);
        Task<bool> RemoveAsync(long id);
        Task<UserForResultDto> RetrieveByIdAsync(long id);
        Task<UserForResultDto> ModifyAsync(long id, UserForUpdateDto dto);
        Task<UserForResultDto> ChangePasswordAsync(UserForChangePasswordDto dto);
    }
}
