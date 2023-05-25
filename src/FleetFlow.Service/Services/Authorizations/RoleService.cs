using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Entities.Authorizations;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs.Roles;
using FleetFlow.Service.Interfaces.Authorizations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<Role> RetrieveByIdAsync(long id)
            =>  await this.roleRepository.SelectAsync(u => u.Id == id);
    }
}
