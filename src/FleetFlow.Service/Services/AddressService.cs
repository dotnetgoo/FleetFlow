using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services;

public class AddressService : IAddressService
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;
    public AddressService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<AddressForResultDto> AddAsync(AddressForCreationDto address)
    {
        var mapped = this.mapper.Map<Address>(address);

        var insertResult = await this.unitOfWork.Addresses.InsertAsync(mapped);
        await this.unitOfWork.SaveChangesAsync();

        return this.mapper.Map<AddressForResultDto>(insertResult);
    }

    public async Task<bool> DeleteByIdAsync(long id)
    {
        var CheckAddress = await this.unitOfWork.Addresses.SelectAsync(a => a.Id == id);

        bool IsDeleted = await this.unitOfWork.Addresses.DeleteAsync(a => a.Id == id);

        if (!IsDeleted) 
            throw new FleetFlowException(404, "Couldn't find product for this given Id");

        await this.unitOfWork.SaveChangesAsync();
        return IsDeleted;
    }

    public async Task<IEnumerable<AddressForResultDto>> GetAllAsync(PaginationParams @params)
    {
        var addressQuery = this.unitOfWork.Addresses.SelectAll();

        if (addressQuery is null)
            throw new FleetFlowException(404, "Address not found");

        var addresses = await addressQuery.ToPagedList(@params).ToListAsync();
        return this.mapper.Map<IEnumerable<AddressForResultDto>>(addresses);
    }

    public async Task<AddressForResultDto> GetByIdAsync(long id)
    {
        var address = await this.unitOfWork.Addresses.SelectAsync(a => a.Id == id);

        if (address is null)
            throw new FleetFlowException(404, "Address Not Found");

        var mapped = this.mapper.Map<AddressForResultDto>(address);

        return mapped;
    }

    public async Task<AddressForResultDto> UpdateByIdAsync(long id, AddressForCreationDto dto)
    {
        var address = await this.unitOfWork.Addresses.SelectAsync(a => a.Id == id);

        if (address is null)
            throw new FleetFlowException(404, "Couldn't find Address");

        var mapped = this.mapper.Map(dto, address);
        mapped.UpdatedAt = DateTime.UtcNow;

        await this.unitOfWork.SaveChangesAsync();

        return this.mapper.Map<AddressForResultDto>(mapped);
    }
}
