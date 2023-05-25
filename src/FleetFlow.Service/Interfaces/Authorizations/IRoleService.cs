using FleetFlow.Domain.Entities.Authorizations;
using FleetFlow.Service.DTOs.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.Interfaces.Authorizations
{
    public interface IRoleService
    {
        Task<Role> RetrieveByIdAsync(long id);
    }
}
