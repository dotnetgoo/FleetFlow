using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Warehouses;
using FleetFlow.Service.DTOs.Inventories;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Interfaces.Addresses;
using FleetFlow.Service.Interfaces.Warehouses;
using FleetFlow.Shared.Helpers;

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

        public async Task<InventoryForResultDto> ModifyAsync(InventoryForUpdateDto inventoryForUpdateDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InventoryForResultDto>> RetrieveAllInventory(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<InventoryForResultDto> RetrieveById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<InventoryForResultDto> RetrieveByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
