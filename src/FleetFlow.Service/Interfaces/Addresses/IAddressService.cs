﻿using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs.Address;
using System.Linq.Expressions;

namespace FleetFlow.Service.Interfaces.Addresses
{
    public interface IAddressService
    {
        Task<AddressForResultDto> AddAsync(AddressForCreationDto address);
        Task<bool> DeleteByIdAsync(long id);
        Task<AddressForResultDto> UpdateByIdAsync(long id, AddressForCreationDto dto);
        Task<AddressForResultDto> GetByIdAsync(long id);
        Task<IEnumerable<AddressForResultDto>> GetAllAsync(PaginationParams @params = null);
    }
}
