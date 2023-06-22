using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Staffs;
using FleetFlow.Service.DTOs.Staffs;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.Authorizations;
using FleetFlow.Service.Interfaces.Staffs;
using FleetFlow.Service.Interfaces.Users;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.Staffs
{
    public class StaffService : IStaffService
    {
        private readonly IRepository<Staff> repository;
        private readonly IUserService userService;
        private readonly IRoleService roleService;
        private readonly IMapper mapper;
        public StaffService(IRepository<Staff> repository,
            IUserService userService,
            IMapper mapper,
            IRoleService roleService,
            IPermissionService permissionService)
        {
            this.repository = repository;
            this.userService = userService;
            this.mapper = mapper;
            this.roleService = roleService;
        }

        public async Task<StaffForResultDto> AddAsync(StaffForCreationDto dto)
        {
            var entity = await this.repository.SelectAsync(x => x.UserId == dto.UserId);
            if (entity is not null && !entity.IsDeleted)
                throw new FleetFlowException(403, "staff already exist");

            if (await this.userService.RetrieveByIdAsync(dto.UserId) is null)
                throw new FleetFlowException(404, "User not found");

            if (await this.roleService.RetrieveByIdAsync(dto.RoleId) is null)
                throw new FleetFlowException(404, "Role not found");

            var mapped = this.mapper.Map<Staff>(dto);
            mapped.CreatedAt = DateTime.UtcNow;
            await this.repository.InsertAsync(mapped);
            await this.repository.SaveAsync();
            return this.mapper.Map<StaffForResultDto>(dto);
        }

        public async Task<StaffForResultDto> ModifyAsync(long id, StaffForUpdateDto dto)
        {
            var entity = await this.repository.SelectAsync(x => x.Id == id);
            if (entity is null || entity.IsDeleted == true)
                throw new FleetFlowException(404, "Staff not found");

            if (await this.userService.RetrieveByIdAsync(dto.UserId) is null)
                throw new FleetFlowException(404, "User not found");

            //if (await this.roleService.RetrieveByIdAsync(dto.RoleId) is null)
            //    throw new FleetFlowException(404, "Role not found");

            var modified = this.mapper.Map(dto, entity);
            modified.UpdatedAt = DateTime.UtcNow;
            modified.UpdatedBy = HttpContextHelper.UserId;

            await this.repository.SaveAsync();

            return this.mapper.Map<StaffForResultDto>(modified);
        }

        public async Task<bool> RemoveAsync(long id)
        {
            var entity = await this.repository.SelectAsync(x => x.Id == id);
            if (entity is null || entity.IsDeleted == true)
                throw new FleetFlowException(404, "Staff not found");
            entity.DeletedBy = HttpContextHelper.UserId;
            await this.repository.DeleteAsync(x => x.Id == id);
            await this.repository.SaveAsync();
            return true;
        }

        public async Task<IEnumerable<StaffForResultDto>> RetrieveAllAsync(PaginationParams @params)
        {
            var entities = await this.repository.SelectAll()
                .Where(u => u.IsDeleted == false)
                .ToPagedList(@params)
                .ToListAsync();

            return this.mapper.Map<IEnumerable<StaffForResultDto>>(entities);
        }

        public async Task<IEnumerable<StaffForResultDto>> RetrieveAllByRoleAsync(PaginationParams @params, long RoleId)
        {
            var entities = await repository.SelectAll()
            .Where(u => u.RoleId == RoleId && !u.IsDeleted)
            .ToPagedList(@params)
            .ToListAsync();

            return mapper.Map<IEnumerable<StaffForResultDto>>(entities);
        }

        public async Task<StaffForResultDto> RetrieveByIdAsync(long id)
        {
            var entity = await this.repository.SelectAsync(x => x.Id == id);
            if (entity is null || entity.IsDeleted == true)
                throw new FleetFlowException(404, "Staff not found");
            return this.mapper.Map<StaffForResultDto>(entity);
        }

        public async Task<StaffForResultDto> RetrieveByUserIdAsync(long UserId)
        {
            var entity = await this.repository.SelectAsync(x => x.UserId == UserId);
            if (entity is null || entity.IsDeleted == true)
                throw new FleetFlowException(404, "Staff not found");
            return this.mapper.Map<StaffForResultDto>(entity);

        }
    }
}
