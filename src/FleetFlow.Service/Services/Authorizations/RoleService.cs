using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Authorizations;
using FleetFlow.Service.DTOs.Roles;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.Authorizations;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.Authorizations
{
    public class RoleService : IRoleService
    {
        private readonly IRepository<Role> roleRepository;
        private readonly IMapper mapper;

        public RoleService(IRepository<Role> roleRepository, IMapper mapper)
        {
            this.roleRepository = roleRepository;
            this.mapper = mapper;
        }

        public async Task<RoleResultDto> AddAsync(RoleCreationDto dto)
        {
            var exist = await this.roleRepository.SelectAsync(r => r.Name.Equals(dto.Name) && r.IsDeleted == true);
            if (exist is not null)
                throw new FleetFlowException(404, "Role is already exist");

            var mappedDto = mapper.Map<Role>(dto);
            await this.roleRepository.InsertAsync(mappedDto);
            await this.roleRepository.SaveAsync();

            return mapper.Map<RoleResultDto>(mappedDto);
        }

        public async Task<IEnumerable<RoleResultDto>> RetrieveAllAsync(PaginationParams @params)
        {
            var roles = await roleRepository.SelectAll()
            .Where(u => u.IsDeleted == false)
            .ToPagedList(@params)
            .ToListAsync();

            return mapper.Map<IEnumerable<RoleResultDto>>(roles);
        }

        public async Task<bool> ModifyAsync(RoleUpdateDto dto)
        {
            var exist = await this.roleRepository.SelectAsync(r => r.Name.Equals(dto.Name) && r.IsDeleted == false);
            if (exist is null)
                throw new FleetFlowException(404, "Role is not found");

            var mappedDto = mapper.Map(dto, exist);
            mappedDto.UpdatedAt = DateTime.UtcNow;
            mappedDto.UpdatedBy = HttpContextHelper.UserId;

            await this.roleRepository.SaveAsync();

            return true;
        }

        public async Task<bool> RemoveAsync(long id)
        {
            var exist = await this.roleRepository.SelectAsync(r => r.Id.Equals(id) && r.IsDeleted == false);
            if (exist is null)
                throw new FleetFlowException(404, "Role is not found");

            await this.roleRepository.DeleteAsync(r => r.Id.Equals(id));
            await this.roleRepository.SaveAsync();

            return true;
        }

        public async Task<Role> RetrieveByIdAsync(long id)
            => await this.roleRepository.SelectAsync(u => u.Id == id && u.IsDeleted == false);


    }
}
