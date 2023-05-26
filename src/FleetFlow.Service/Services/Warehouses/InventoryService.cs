using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Warehouses;
using FleetFlow.Service.DTOs.Inventories;
using FleetFlow.Service.DTOs.Product;
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

        public async Task<InventoryForResultDto> AddAsync(InventoryForCreationDto inventoryCreationDto)
        {
            var existInventory = await this.repository.SelectAsync(i => i.Name.ToLower()
            .Equals(inventoryCreationDto.Name.ToLower()));
            if (existInventory is not null || existInventory.IsDeleted == false)
                throw new FleetFlowException(409, "Inventory already exist");

            var existAddress = await this.addressService.GetByIdAsync(inventoryCreationDto.AddressId);
            if (existAddress is null)
                throw new FleetFlowException(403, "There is no address with given address id");
            
            var mappedInventory = this.mapper.Map<Inventory>(existInventory);
            mappedInventory.CreatedAt = DateTime.UtcNow;
            mappedInventory.OwnerId = HttpContextHelper.UserId;
            var addedInventory = await this.repository.InsertAsync(mappedInventory);
            await this.repository.SaveAsync();

            return this.mapper.Map<InventoryForResultDto>(addedInventory);
        }

        public async Task<InventoryForResultDto> ModifyAsync(long id,InventoryForUpdateDto inventoryForUpdateDto)
        {
            var existInventory = await this.repository.SelectAsync(model => model.Id == id);
            if (existInventory is null || existInventory.IsDeleted == true)
                throw new FleetFlowException(404, "Inventory not found");

            var location = await this.addressService.GetByIdAsync(inventoryForUpdateDto.LocationId);
            if (location is null)
                throw new FleetFlowException(400, "Given location id is not exist");

            var mappedInventory = this.mapper.Map(inventoryForUpdateDto, existInventory);
            mappedInventory.UpdatedAt = DateTime.UtcNow;
            mappedInventory.UpdatedBy = HttpContextHelper.UserId;
            await this.repository.SaveAsync();

            return mapper.Map<InventoryForResultDto>(mappedInventory);
        }

        public async Task<bool> RemoveAsync(long id)
        {
            var existInventory = await this.repository.SelectAsync(i => i.Id == id);
            if (existInventory is null || existInventory.IsDeleted)
                throw new FleetFlowException(404, "Couldn't find inventory for this given Id");

            await this.repository.DeleteAsync(i => i.Id.Equals(existInventory));
            existInventory.DeletedBy = HttpContextHelper.UserId;
            await this.repository.SaveAsync();
            return true;
        }

        public async Task<IEnumerable<InventoryForResultDto>> RetrieveAllInventory(PaginationParams @params)
        {
            var inventories = await this.repository.SelectAll()
            .Where(p => !p.IsDeleted)
            .ToPagedList(@params)
            .ToListAsync();

            return this.mapper.Map<IEnumerable<InventoryForResultDto>>(inventories);
        }

        public async Task<InventoryForResultDto> RetrieveById(long id)
        {
            var inventory = await this.repository.SelectAsync(i=>i.Id == id);

            if (inventory is null || inventory.IsDeleted)
                throw new FleetFlowException(404, "Inventory not found");

            return mapper.Map<InventoryForResultDto>(inventory);
        }

        public async Task<InventoryForResultDto> RetrieveByName(string name)
        {
            var inventory = await this.repository.SelectAsync(i=>i.Name== name);

        }
    }
}
