using FleetFlow.DAL.IRepositories;
using FleetFlow.DAL.Repositories;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs;
using FleetFlow.Service.Interfaces;
using System.Linq.Expressions;

namespace FleetFlow.Service.Services;

public class AddressService : IAddressService
{
    private readonly IUnitOfWork unitOfWork;
    public AddressService(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }
    public async Task<AddressForResultDto> AddAsync(AddressForCreationDto address)
    {
        // Check for exist Address
        var ExistAddress = unitOfWork.Addresses.SelectAsync(x => x.ZipCode == address.ZipCode);
        if(ExistAddress is not null)
        {
            throw new Exception("Address already exist");
        }

        var result = await unitOfWork.Addresses.InsertAsync(address);

        await unitOfWork.SaveChangesAsync();

        return result;
    }

    public async Task<bool> DeleteAsync(Expression<Func<Address, bool>> predicate)
    {
        
    }

    public Task<IEnumerable<AddressForResultDto>> GetAllAsync(Expression<Func<Address, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<AddressForResultDto> GetAsync(Expression<Func<Address, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<AddressForResultDto> UpdateAsync(Expression<Func<Address, bool>> predicate, AddressForCreationDto dto)
    {
        throw new NotImplementedException();
    }
}
