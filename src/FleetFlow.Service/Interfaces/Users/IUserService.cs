using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Service.DTOs.User;

namespace FleetFlow.Service.Interfaces.Users
{
    public interface IUserService
    {
        Task<UserForResultDto> AddAsync(UserForCreationDto dto);
        Task<IEnumerable<UserForResultDto>> RetrieveAllAsync(PaginationParams @params);
        Task<IEnumerable<UserForResultDto>> RetrieveAllByRoleAsync(PaginationParams @params, long roleId);
        Task<User> RetrieveByEmailAsync(string email);
        Task<bool> RemoveAsync(long id);
        Task<UserForResultDto> RetrieveByIdAsync(long id);
        Task<UserForResultDto> ModifyAsync(long id, UserForUpdateDto dto);
        Task<UserForResultDto> ChangePasswordAsync(UserForChangePasswordDto dto);
    }
}
