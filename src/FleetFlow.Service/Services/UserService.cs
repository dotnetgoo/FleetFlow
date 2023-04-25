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

namespace FleetFlow.Service.Services;

public class UserService : IUserService
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;
    public UserService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
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
        var existUser = await unitOfWork.Users.SelectAsync(p => p.Phone == dto.Phone);
        if (existUser != null)
            throw new FleetFlowException(409, "User already exist");

        var mapped = this.mapper.Map<User>(dto);
        mapped.CreatedAt = DateTime.UtcNow;
        var addedModel = await unitOfWork.Users.InsertAsync(mapped);

        await unitOfWork.SaveChangesAsync();

        return this.mapper.Map<UserForResultDto>(addedModel);
    }

    /// <summary>
    /// Removed user from database by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="FleetFlowException"></exception>
    public async Task<bool> RemoveAsync(long id)
    {
        var user = await this.unitOfWork.Users.SelectAsync(u => u.Id == id);
        if (user is null)
            throw new FleetFlowException(404, "Couldn't find user for this given Id");

        await this.unitOfWork.Users.DeleteAsync(u => u.Id == id);

        await this.unitOfWork.SaveChangesAsync();

        return true;
    }

    /// <summary>
    /// Retrieves all users from database with pagination
    /// </summary>
    /// <param name="params"></param>
    /// <returns></returns>
    public async Task<IEnumerable<UserForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var users = await unitOfWork.Users.SelectAll()
                                    .ToPagedList(@params).ToListAsync();

        return this.mapper.Map<IEnumerable<UserForResultDto>>(users);
    }

    /// <summary>
    /// Retrieves all user from database with pagination by role
    /// </summary>
    /// <param name="params"></param>
    /// <param name="role"></param>
    /// <returns></returns>
    public async Task<IEnumerable<UserForResultDto>> RetrieveAllByRoleAsync(PaginationParams @params, UserRole role = UserRole.Admin)
    {
        var users = await unitOfWork.Users.SelectAll()
                        .Where(u => u.Role == role).ToPagedList(@params).ToListAsync();

        return this.mapper.Map<IEnumerable<UserForResultDto>>(users);

    }

    /// <summary>
    /// Retrieves user from database by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="FleetFlowException"></exception>
    public async Task<UserForResultDto> RetrieveByIdAsync(long id)
    {
        var user = await this.unitOfWork.Users.SelectAsync(u => u.Id == id);
        if (user is null)
            throw new FleetFlowException(404, "User Not Found");

        return this.mapper.Map<UserForResultDto>(user);
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
        var user = await this.unitOfWork.Users.SelectAsync(u => u.Id == id);
        if (user is null)
            throw new FleetFlowException(404, "Couldn't found user for given Id");

        var modifiedUser = this.mapper.Map(dto, user);
        modifiedUser.UpdatedAt = DateTime.UtcNow;

        await this.unitOfWork.SaveChangesAsync();

        return this.mapper.Map<UserForResultDto>(user);
    }
}