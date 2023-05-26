using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Warehouses;
using FleetFlow.Service.DTOs.Inventories;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.Addresses;
using FleetFlow.Service.Interfaces.Warehouses;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.Warehouses
{
    public class InventoryService : IInventoryService
    {
        private readonly IRepository<Inventory> repository;
        private readonly IMapper mapper;
        private readonly IAddressService addressService;
        public InventoryService(IRepository<Inventory> repository, IMapper mapper, IAddressService addressService)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.addressService = addressService;
        }

        public async Task<InventoryForResultDto> AddAsync(InventoryForCreationDto dto)
        {
            var existInventory = await this.repository.SelectAsync(i => i.Name.ToLower()
            .Equals(dto.Name.ToLower()));
            if (existInventory is not null && existInventory.IsDeleted == false)
                throw new FleetFlowException(409, "Inventory already exist");

            if (await this.addressService.GetByIdAsync(dto.AddressId) is null)
                throw new FleetFlowException(403, "There is no address with given address id");
            
            var mappedInventory = this.mapper.Map<Inventory>(dto);
            mappedInventory.CreatedAt = DateTime.UtcNow;
            mappedInventory.OwnerId = HttpContextHelper.UserId;
            var addedInventory = await this.repository.InsertAsync(mappedInventory);
            await this.repository.SaveAsync();

            return this.mapper.Map<InventoryForResultDto>(addedInventory);
        }

        public async Task<InventoryForResultDto> ModifyAsync(long id, InventoryForUpdateDto dto)
        {
            var existInventory = await this.repository.SelectAsync(i => i.Id == id);
            if (existInventory is null || existInventory.IsDeleted == true)
                throw new FleetFlowException(404, "Inventory not found");
            if (await this.addressService.GetByIdAsync(dto.AddressId) is null)
                throw new FleetFlowException(403, "There is no address with given address id");

            var mappedInventory = this.mapper.Map(dto, existInventory);
            mappedInventory.UpdatedAt = DateTime.UtcNow;
            mappedInventory.UpdatedBy = HttpContextHelper.UserId;
            await this.repository.SaveAsync();
            return this.mapper.Map<InventoryForResultDto>(mappedInventory);

        }

        public async Task<bool> RemoveAsync(long id)
        {
            var existInventory = await this.repository.SelectAsync(i => i.Id == id);
            if (existInventory is null || existInventory.IsDeleted == true)
                throw new FleetFlowException(404, "Couldn't find inventory for this given Id");

            existInventory.DeletedBy = HttpContextHelper.UserId;
            
            await this.repository.DeleteAsync(i => i.Id == id);
            await this.repository.SaveAsync();

            return true;
        }

        public async Task<IEnumerable<InventoryForResultDto>> RetrieveAllInventory(PaginationParams @params)
        {
            var inventories = await this.repository.SelectAll()
            .Where(u => u.IsDeleted == false)
            .ToPagedList(@params)
            .ToListAsync();

            return mapper.Map<IEnumerable<InventoryForResultDto>>(inventories);
        }

        public async Task<InventoryForResultDto> RetrieveById(long id)
        {
            var existInventory = await this.repository.SelectAsync(i => i.Id == id);
            if (existInventory is null || existInventory.IsDeleted == true)
                throw new FleetFlowException(404, "Inventory not found");

            return this.mapper.Map<InventoryForResultDto>(existInventory);
        }

        public async Task<InventoryForResultDto> RetrieveByName(string name)
        {
            var existInventory = await this.repository.SelectAsync(i => i.Name.ToLower().Equals(name.ToLower()));
            if (existInventory is null || existInventory.IsDeleted == true)
                throw new FleetFlowException(404, "Inventory not found");

            return this.mapper.Map<InventoryForResultDto>(existInventory);
        }
    }
}
