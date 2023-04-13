using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Interfaces;
using System.Linq.Expressions;

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
        // Check for exist Address
        var checkAddress = await this.unitOfWork.Addresses.SelectAsync(x => x.ZipCode == address.ZipCode);
        if (checkAddress is not null)
        {
            throw new FleetFlowException(409, "Address already exist");
        }

        var mapped = this.mapper.Map<Address>(address);
        var insertResult = await this.unitOfWork.Addresses.InsertAsync(mapped);
        await this.unitOfWork.SaveChangesAsync();

        var result = this.mapper.Map<AddressForResultDto>(insertResult);
        return result;
    }

    public async Task<bool> DeleteAsync(Expression<Func<Address, bool>> predicate)
    {
        var CheckAddress = await this.unitOfWork.Addresses.SelectAsync(predicate);
        if (CheckAddress is null) throw new FleetFlowException(404, "Couldn't find product for this given Id");

        bool IsDeleted = await this.unitOfWork.Addresses.DeleteAsync(predicate);
        await this.unitOfWork.SaveChangesAsync();

        return IsDeleted;
    }

    public async Task<IEnumerable<AddressForResultDto>> GetAllAsync(Expression<Func<Address, bool>> predicate)
    {
        var addresses = this.unitOfWork.Addresses.SelectAll();

        if (addresses is null)
            throw new FleetFlowException(404, "Address not found");
        var mapped = this.mapper.Map<IEnumerable<AddressForResultDto>>(addresses);

        return mapped;
    }

    public async Task<AddressForResultDto> GetAsync(Expression<Func<Address, bool>> predicate)
    {
        var address = await this.unitOfWork.Addresses.SelectAsync(predicate);

        if (address is null)
            throw new FleetFlowException(404, "Address Not Found");

        var mapped = this.mapper.Map<AddressForResultDto>(address);

        return mapped;
    }

    public async Task<AddressForResultDto> UpdateAsync(Expression<Func<Address, bool>> predicate, AddressForCreationDto dto)
    {
        var address = await this.unitOfWork.Addresses.SelectAsync(predicate);
        if (address is null)
            throw new FleetFlowException(404, "Couldn't found Address");

        var mapped = this.mapper.Map(dto, address);
        mapped.UpdatedAt = DateTime.UtcNow;

        await this.unitOfWork.SaveChangesAsync();

        return this.mapper.Map<AddressForResultDto>(mapped);
    }
}
