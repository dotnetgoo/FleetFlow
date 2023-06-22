using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Authorizations;
using FleetFlow.Service.DTOs.Permissions;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.Authorizations;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.Authorizations
{
    public class PermissionService : IPermissionService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Permission> permissionRepository;
        public PermissionService(IMapper mapper, IRepository<Permission> permissionRepository)
        {
            this.mapper = mapper;
            this.permissionRepository = permissionRepository;
        }

        public async Task<PermissionForResultDto> CreateAsync(PermissionForCreationDto dto)
        {
            var permission = await this.permissionRepository.SelectAsync(p => p.Name.ToLower() == dto.Name.ToLower() && p.IsDeleted == true);
            if (permission is not null)
                throw new FleetFlowException(409, "Permission is already available");

            var mappedPermission = this.mapper.Map<Permission>(dto);
            mappedPermission.CreatedAt = DateTime.UtcNow;
            var result = await this.permissionRepository.InsertAsync(mappedPermission);
            await this.permissionRepository.SaveAsync();

            return this.mapper.Map<PermissionForResultDto>(result);
        }

        public async Task<List<PermissionForResultDto>> RetrieveAllAsync(PaginationParams @params)
        {
            var permissions = await permissionRepository.SelectAll()
                .Where(p => p.IsDeleted == false)
                .ToPagedList(@params)
                .ToListAsync();

            return mapper.Map<List<PermissionForResultDto>>(permissions);
        }

        public async Task<PermissionForResultDto> RetrieveByIdAsync(long id)
        {
            var permission = await this.permissionRepository.SelectAsync(p => p.Id == id && p.IsDeleted == false);
            if (permission is null)
                throw new FleetFlowException(404, "Permission is not available");

            return this.mapper.Map<PermissionForResultDto>(permission);
        }

        public async Task<bool> RemoveAsync(long id)
        {
            var permission = await this.permissionRepository.DeleteAsync(p => p.Id == id && p.IsDeleted == false);
            if (!permission)
                throw new FleetFlowException(404, "Permission is not available");

            await this.permissionRepository.SaveAsync();
            return true;
        }

        public async Task<PermissionForResultDto> ModifyAsync(PermissionForUpdateDto dto)
        {
            var permission = await this.permissionRepository.SelectAsync(u => u.Id == dto.Id && u.IsDeleted == false);
            if (permission is null)
                throw new FleetFlowException(404, "Permission is not found ");

            var result = this.mapper.Map(dto, permission);
            result.UpdatedAt = DateTime.UtcNow;
            await this.permissionRepository.SaveAsync();

            return this.mapper.Map<PermissionForResultDto>(result);
        }
    }
}
