﻿using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using Microsoft.EntityFrameworkCore;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Domain.Entities.Addresses;
using FleetFlow.Service.Interfaces.Addresses;


namespace FleetFlow.Service.Services.Addresses;

public class AddressService : IAddressService
{
    private readonly IRepository<Address> addressRepository;
    private readonly IMapper mapper;
    public AddressService(IMapper mapper, IRepository<Address> addressRepository)
    {
        this.mapper = mapper;
        this.addressRepository = addressRepository;
    }

    public async Task<AddressForResultDto> AddAsync(AddressForCreationDto address)
    {
        var mapped = mapper.Map<Address>(address);

        var insertResult = await this.addressRepository.InsertAsync(mapped);
        await addressRepository.SaveAsync();

        return mapper.Map<AddressForResultDto>(insertResult);
    }

    public async Task<bool> DeleteByIdAsync(long id)
    {
        var CheckAddress = await this.addressRepository.SelectAsync(a => a.Id == id);

        bool IsDeleted = await this.addressRepository.DeleteAsync(a => a.Id == id);

        if (!IsDeleted)
            throw new FleetFlowException(404, "Couldn't find product for this given Id");

        await this.addressRepository.SaveAsync();
        return IsDeleted;
    }

    public async Task<IEnumerable<AddressForResultDto>> GetAllAsync(PaginationParams @params)
    {
        var addressQuery = this.addressRepository.SelectAll();

        if (addressQuery is null)
            throw new FleetFlowException(404, "Address not found");

        var addresses = await addressQuery.ToPagedList(@params).ToListAsync();
        return mapper.Map<IEnumerable<AddressForResultDto>>(addresses);
    }

    public async Task<AddressForResultDto> GetByIdAsync(long id)
    {
        var address = await this.addressRepository.SelectAsync(a => a.Id == id);

        if (address is null)
            throw new FleetFlowException(404, "Address Not Found");

        var mapped = mapper.Map<AddressForResultDto>(address);

        return mapped;
    }

    public async Task<AddressForResultDto> UpdateByIdAsync(long id, AddressForCreationDto dto)
    {
        var address = await this.addressRepository.SelectAsync(a => a.Id == id);

        if (address is null)
            throw new FleetFlowException(404, "Couldn't find Address");

        var mapped = mapper.Map(dto, address);
        mapped.UpdatedAt = DateTime.UtcNow;

        await this.addressRepository.SaveAsync();

        return mapper.Map<AddressForResultDto>(mapped);
    }
}
