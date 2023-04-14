using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.Interfaces
{
    public interface IAddressService
    {
        Task<AddressForResultDto> AddAsync(AddressForCreationDto address);
        Task<bool> DeleteAsync(Expression<Func<Address, bool>> predicate);
        Task<AddressForResultDto> UpdateAsync(Expression<Func<Address, bool>> predicate, AddressForCreationDto dto);
        Task<AddressForResultDto> GetAsync(Expression<Func<Address, bool>> predicate);
        Task<IEnumerable<AddressForResultDto>> GetAllAsync(Expression<Func<Address, bool>> predicate);
    }
}
