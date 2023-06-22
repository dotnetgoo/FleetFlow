using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Warehouses;
using FleetFlow.Service.DTOs.Inventories;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.Products;
using FleetFlow.Service.Interfaces.Warehouses;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.Warehouses
{
    public class ProductInventoryService : IProductInventoryService
    {
        private readonly IRepository<ProductInventory> repository;
        private readonly IProductService productService;
        private readonly ILocationService locationService;
        private readonly IInventoryService inventoryService;
        private readonly IMapper mapper;
        public ProductInventoryService(IRepository<ProductInventory> repository,
            IProductService productService,
            ILocationService locationService,
            IInventoryService inventoryService,
            IMapper mapper)
        {
            this.repository = repository;
            this.productService = productService;
            this.locationService = locationService;
            this.inventoryService = inventoryService;
            this.mapper = mapper;
        }

        public async Task<ProductInventoryResultDto> AddAsync(ProductInventoryCreationDto dto)
        {
            var entity = await this.repository.SelectAsync(p => p.ProductId == dto.ProductId &&
                p.InventoryId == dto.InventoryId &&
                p.LocationId == dto.LocationId);

            if (entity is not null && entity.IsDeleted == false)
                throw new FleetFlowException(403, "Already exist");

            var product = await this.productService.RetrieveByIdAsync(dto.ProductId);
            if (product is null)
                throw new FleetFlowException(404, "There is no product with given id");

            var location = await this.locationService.RetrieveByIdAsync(dto.LocationId);
            if (location is null)
                throw new FleetFlowException(404, "There is no location with given id");

            var inventory = await this.inventoryService.RetrieveById(dto.InventoryId);
            if (inventory is null)
                throw new FleetFlowException(404, "There is not inventory with given id");

            var mapped = this.mapper.Map<ProductInventory>(dto);
            mapped.CreatedAt = DateTime.UtcNow;

            var added = await this.repository.InsertAsync(mapped);
            await this.repository.SaveAsync();

            return this.mapper.Map<ProductInventoryResultDto>(added);

        }
        public async Task<ProductInventoryResultDto> AddQuantity(long ProductId, long InventoryId, int amount)
        {
            var model = await this.repository.SelectAsync(x => x.ProductId == ProductId && x.InventoryId == InventoryId);
            if (model is null || model.IsDeleted == true)
                throw new FleetFlowException(404, "Product not found");
            model.Amount += amount;
            await this.repository.SaveAsync();
            return this.mapper.Map<ProductInventoryResultDto>(model);
        }
        public async Task<ProductInventoryResultDto> RemoveQuantity(long ProductId, long InventoryId, int amount)
        {
            var model = await this.repository.SelectAsync(x => x.ProductId == ProductId && x.InventoryId == InventoryId);
            if (model is null || model.IsDeleted == true)
                throw new FleetFlowException(404, "Product not found");

            if (model.Amount < amount)
                throw new FleetFlowException(400, $"There are {model.Amount} products in the warehouse");

            model.Amount -= amount;
            await this.repository.SaveAsync();
            return this.mapper.Map<ProductInventoryResultDto>(model);
        }
        public async Task<ProductInventoryResultDto> ModifyAsync(long id, ProductInventoryUpdateDto dto)
        {
            var product = await this.repository.SelectAsync(x => x.Id == id);
            if (product is null || product.IsDeleted == true)
                throw new FleetFlowException(404, "Product not found");

            var productModel = await this.productService.RetrieveByIdAsync(dto.ProductId);
            if (productModel is null)
                throw new FleetFlowException(404, "There is no product with given id");

            var location = await this.locationService.RetrieveByIdAsync(dto.LocationId);
            if (location is null)
                throw new FleetFlowException(404, "There is no location with given id");

            var inventory = await this.inventoryService.RetrieveById(dto.InventoryId);
            if (inventory is null)
                throw new FleetFlowException(404, "There is not inventory with given id");

            var mapped = this.mapper.Map(dto, product);
            mapped.UpdatedBy = HttpContextHelper.UserId;
            mapped.UpdatedAt = DateTime.UtcNow;

            await this.repository.SaveAsync();
            return this.mapper.Map<ProductInventoryResultDto>(mapped);
        }

        public async Task<IEnumerable<ProductInventoryResultDto>> RetrieveAllAsync(PaginationParams @params)
        {
            var products = await this.repository.SelectAll()
            .Where(u => u.IsDeleted == false)
            .ToPagedList(@params)
            .ToListAsync();

            return mapper.Map<IEnumerable<ProductInventoryResultDto>>(products);
        }
        public async Task<ProductInventoryResultDto> RetrieveByIdAsync(long id)
        {
            var entity = await this.repository.SelectAsync(x => x.Id == id);

            if (entity is null || entity.IsDeleted == true)
                throw new FleetFlowException(404, "Product not found");
            return this.mapper.Map<ProductInventoryResultDto>(entity);

        }

        public async Task<bool> RemoveAsync(long id)
        {
            var entity = await this.repository.SelectAsync(x => x.Id == id);

            if (entity is null || entity.IsDeleted == true)
                throw new FleetFlowException(404, "Product not found");

            entity.DeletedBy = HttpContextHelper.UserId;

            await this.repository.DeleteAsync(i => i.Id == id);
            await this.repository.SaveAsync();

            return true;
        }

        public async Task<IEnumerable<ProductInventoryResultDto>> RetrieveProductById(long ProductId)
        {
            var products = await this.repository.SelectAll(x => x.ProductId == ProductId)
            .Where(u => u.IsDeleted == false)
            .ToListAsync();

            return mapper.Map<IEnumerable<ProductInventoryResultDto>>(products);
        }
    }
}
