using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.StaffPermissions;
using FleetFlow.Service.DTOs.StaffPermissions;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.Authorizations;
using FleetFlow.Service.Interfaces.StaffPermissions;
using FleetFlow.Service.Interfaces.Staffs;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Math.EC.Rfc7748;

namespace FleetFlow.Service.Services
{
    public class StaffPermissionService : IStaffPermissionService
    {
        private readonly IRepository<StaffPermission> repository;
        private readonly IPermissionService permissionService;
        private readonly IStaffService staffService;
        private readonly IMapper mapper;
        public StaffPermissionService(IRepository<StaffPermission> repository,
            IPermissionService permissionService,
            IStaffService staffService,
            IMapper mapper
            )
        {
            this.repository = repository;
            this.permissionService = permissionService;
            this.staffService = staffService;
            this.mapper = mapper;
        }

        public async Task<StaffPermissionForResultDto> AddPermission(StaffPermissionsForCreationDto dto)
        {
            var entity = await this.repository.SelectAsync(x => x.StaffId == dto.StaffId &&
                x.PermissionId == dto.PermissionId);
            if (entity is not null && entity.IsDeleted == true)
                throw new FleetFlowException(403, "Already exist");
            if (await this.staffService.RetrieveByIdAsync(dto.StaffId) is null)
                throw new FleetFlowException(404, "Staff not found");
            if (await this.permissionService.RetrieveByIdAsync(dto.PermissionId) is null)
                throw new FleetFlowException(404, "Permission not found");
            var model = this.mapper.Map<StaffPermission>(dto);
            await this.repository.InsertAsync(model);
            return this.mapper.Map<StaffPermissionForResultDto>(dto);
        }

        public async Task<IEnumerable<StaffPermissionForResultDto>> GetStaffsAllPermissions(PaginationParams @params, long staffId)
        {
            var entities = await this.repository.SelectAll()
                .Where(x => x.StaffId == staffId)
                .ToPagedList(@params)
                .ToListAsync();
            return this.mapper.Map<IEnumerable<StaffPermissionForResultDto>>(entities);
        }

        public async Task<bool> RemovePermission(StaffPermissionsForCreationDto dto)
        {
            var entity = await this.repository.SelectAsync(x => x.StaffId == dto.StaffId &&
                x.PermissionId == dto.PermissionId);
            if (entity is not null && entity.IsDeleted == true)
                throw new FleetFlowException(403, "Already exist");
            if (await this.staffService.RetrieveByIdAsync(dto.StaffId) is null)
                throw new FleetFlowException(404, "Staff not found");
            if (await this.permissionService.RetrieveByIdAsync(dto.PermissionId) is null)
                throw new FleetFlowException(404, "Permission not found");
            
            await this.repository.DeleteAsync(x => x.Id == entity.Id);
            return true;
        }
    }
}
