﻿using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Authorizations;
using FleetFlow.Service.DTOs.Roles;

namespace FleetFlow.Service.Interfaces.Authorizations
{
    public interface IRoleService
    {
        Task<RoleResultDto> AddAsync(RoleCreationDto dto);
        Task<bool> ModifyAsync(RoleUpdateDto dto);
        Task<bool> RemoveAsync(long id);
        Task<IEnumerable<RoleResultDto>> RetrieveAllAsync(PaginationParams @params = null);
        Task<Role> RetrieveByIdForAuthAsync(long id);
        Task<RoleResultDto> RetrieveByIdAsync(long id);
    }
}
