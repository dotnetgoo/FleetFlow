using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Authorizations;
using FleetFlow.Service.DTOs.RolePermissions;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.Authorizations;
using Microsoft.EntityFrameworkCore;


namespace FleetFlow.Service.Services.Authorizations
{
    public class RolePermissionService : IRolePermissionService
    {
        private readonly IMapper mapper;
        private readonly IRepository<RolePermission> rolePermissionRepository;
        public RolePermissionService(IMapper mapper, IRepository<RolePermission> rolePermissionRepository)
        {
            this.mapper = mapper;
            this.rolePermissionRepository = rolePermissionRepository;
        }

        public async Task<RolePermissionForResultDto> CreateAsync(RolePermissionForCreateDto permission)
        {
            var rolePermission = await this.rolePermissionRepository.SelectAsync(rp => rp.RoleId==permission.RoleId && rp.PermissonId==permission.PermissonId && rp.IsDeleted ==true);
            if (rolePermission is not null)
                throw new FleetFlowException(409, "RolePermission is already exist");

            var mappedRolePermission = this.mapper.Map<RolePermission>(permission);
            mappedRolePermission.CreatedAt = DateTime.UtcNow;
            var result = await this.rolePermissionRepository.InsertAsync(mappedRolePermission);
            await this.rolePermissionRepository.SaveAsync();

            return this.mapper.Map<RolePermissionForResultDto>(result);
        }

        public async Task<bool> RemoveAsync(long id)
        {
            var result = await this.rolePermissionRepository.DeleteAsync(rp => rp.Id == id && rp.IsDeleted == false);
            if (!result)
                throw new FleetFlowException(404, "RolePermission is not available");

            return result;
        }

        public async Task<List<RolePermissionForResultDto>> RetrieveAllAsync(PaginationParams @params)
        {
            var permissions = await rolePermissionRepository.SelectAll(p => p.IsDeleted == false && p.Permisson.IsDeleted == false && p.Role.IsDeleted == false, new string[] { "Permisson", "Role" })
                    .Where(p => p.IsDeleted == false)
                    .ToPagedList(@params)
                    .ToListAsync();

            return this.mapper.Map<List<RolePermissionForResultDto>>(permissions);
        }

        public async Task<RolePermissionForResultDto> ModifyAsync(RolePermissionForUpdateDto permission)
        {
            var rolePermission = await this.rolePermissionRepository.SelectAsync(rp => rp.Id == permission.Id && rp.IsDeleted ==false);
            if (rolePermission is null)
                throw new FleetFlowException(404, "RolePermission is not available");
            var result = this.mapper.Map(permission, rolePermission);
            result.UpdatedAt = DateTime.UtcNow;
            await this.rolePermissionRepository.SaveAsync();

            return this.mapper.Map<RolePermissionForResultDto>(result);
        }

        public async Task<RolePermissionForResultDto> RetrieveByIdAsync(long id)
        {
            var rolePermission = await this.rolePermissionRepository.SelectAll(rp => rp.Id == id && rp.IsDeleted == false && rp.Permisson.IsDeleted ==false && rp.Role.IsDeleted ==false, new string[] { "Permisson", "Role" })
                .FirstOrDefaultAsync();
            if (rolePermission is null)
                throw new FleetFlowException(404, "RolePermission is not found");

            return this.mapper.Map<RolePermissionForResultDto>(rolePermission);
        }

        public async Task<bool> CheckPermission(string role, string accessedMethod)
        {
            var permissions = await this.rolePermissionRepository
                .SelectAll(p => p.Role.Name.ToLower() == role.ToLower() && p.Permisson.IsDeleted==false && p.Role.IsDeleted == false, new string[] { "Permisson" })
                .ToListAsync();
            foreach (var permission in permissions)
            {
                if (permission?.Permisson?.Name.ToLower()==accessedMethod.ToLower())
                    return true;
            }

            return false;

        }
    }
}
