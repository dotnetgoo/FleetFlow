using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Entities.Authorizations;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Service.DTOs.User;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.Users;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.Users;

public class UserService : IUserService
{
    private readonly IMapper mapper;
    private readonly IRepository<User> userRepository;
    private readonly IRepository<Cart> cartRepository;
    private readonly IRepository<Role> roleRepository;
    public UserService(
        IMapper mapper,
        IRepository<User> userRepository,
        IRepository<Cart> cartRepository,
        IRepository<Role> roleRepository)
    {
        this.mapper = mapper;
        this.userRepository = userRepository;
        this.cartRepository = cartRepository;
        this.roleRepository = roleRepository;
    }

    /// <summary>
    /// Adds new User to database
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    /// <exception cref="FleetFlowException"></exception>
    public async Task<UserForResultDto> AddAsync(UserForCreationDto dto)
    {
        // check for exist user
        var existUser = await userRepository.SelectAsync(p => p.Phone == dto.Phone);
        if (existUser != null && !existUser.IsDeleted)
            throw new FleetFlowException(409, "User already exist");

        var userRole = await this.roleRepository.SelectAsync(t => t.Name.ToLower() == "user");

        var mapped = mapper.Map<User>(dto);
        mapped.RoleId = userRole.Id;
        mapped.CreatedAt = DateTime.UtcNow;
        mapped.Password = PasswordHelper.Hash(dto.Password);
        var addedModel = await userRepository.InsertAsync(mapped);
        await userRepository.SaveAsync();

        var newCart = new Cart();
        newCart.UserId = addedModel.Id;
        await cartRepository.InsertAsync(newCart);
        await cartRepository.SaveAsync();

        return mapper.Map<UserForResultDto>(addedModel);
    }

    /// <summary>
    /// Removed user from database by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="FleetFlowException"></exception>
    public async Task<bool> RemoveAsync(long id)
    {
        var user = await userRepository.SelectAsync(u => u.Id == id);
        if (user is null || user.IsDeleted)
            throw new FleetFlowException(404, "Couldn't find user for this given Id");

        // init deleter id
        var accessor = HttpContextHelper.Accessor;
        user.DeletedBy = HttpContextHelper.UserId;

        await userRepository.DeleteAsync(u => u.Id == id);

        var cart = await cartRepository.SelectAsync(c => c.UserId.Equals(id));
        if (cart is not null)
            await cartRepository.DeleteAsync(c => c.Id == cart.Id);

        await cartRepository.SaveAsync();
        await userRepository.SaveAsync();

        return true;
    }

    /// <summary>
    /// Retrieves all users from database with pagination
    /// </summary>
    /// <param name="params"></param>
    /// <returns></returns>
    public async Task<IEnumerable<UserForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var users = await userRepository.SelectAll()
            .Where(u => u.IsDeleted == false)
            .ToPagedList(@params)
            .ToListAsync();

        return mapper.Map<IEnumerable<UserForResultDto>>(users);
    }

    /// <summary>
    /// Retrieves all user from database with pagination by role
    /// </summary>
    /// <param name="params"></param>
    /// <param name="role"></param>
    /// <returns></returns>
    public async Task<IEnumerable<UserForResultDto>> RetrieveAllByRoleAsync(PaginationParams @params, long roleId)
    {
        var users = await userRepository.SelectAll()
            .Where(u => u.RoleId == roleId && !u.IsDeleted)
            .ToPagedList(@params)
            .ToListAsync();

        return mapper.Map<IEnumerable<UserForResultDto>>(users);

    }

    /// <summary>
    /// Retrieves user from database by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="FleetFlowException"></exception>
    public async Task<UserForResultDto> RetrieveByIdAsync(long id)
    {
        var user = await userRepository.SelectAsync(u => u.Id == id);
        if (user is null || user.IsDeleted)
            throw new FleetFlowException(404, "User Not Found");

        return mapper.Map<UserForResultDto>(user);
    }

    /// <summary>
    /// Modified user by id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="dto"></param>
    /// <returns></returns>
    /// <exception cref="FleetFlowException"></exception>
    public async Task<UserForResultDto> ModifyAsync(long id, UserForUpdateDto dto)
    {
        var user = await userRepository.SelectAsync(u => u.Id == id);
        if (user is null || user.IsDeleted)
            throw new FleetFlowException(404, "Couldn't found user for given Id");

        var modifiedUser = mapper.Map(dto, user);
        modifiedUser.UpdatedAt = DateTime.UtcNow;
        modifiedUser.UpdatedBy = HttpContextHelper.UserId;

        await userRepository.SaveAsync();

        return mapper.Map<UserForResultDto>(user);
    }
    /// <summary>
    /// Retrieve user by email
    /// </summary>
    /// <param name="email"></param>
    /// <returns></returns>
    public async Task<User> RetrieveByEmailAsync(string email)
        => await userRepository.SelectAsync(u => u.Email == email);

    /// <summary>
    /// Change user password
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<UserForResultDto> ChangePasswordAsync(UserForChangePasswordDto dto)
    {
        var user = await userRepository.SelectAsync(u => u.Email == dto.Email);
        if (user is null || user.IsDeleted)
            throw new FleetFlowException(404, "User not found!");

        if (!PasswordHelper.Verify(dto.OldPassword, user.Password))
            throw new FleetFlowException(400, "Password is incorrect");

        if (dto.NewPassword != dto.ComfirmPassword)
            throw new FleetFlowException(400, "New password and confirm password are not equal");

        user.Password = PasswordHelper.Hash(dto.NewPassword);
        user.UpdatedBy = HttpContextHelper.UserId;
        await userRepository.SaveAsync();

        return mapper.Map<UserForResultDto>(user);
    }
}