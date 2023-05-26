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
using Microsoft.EntityFrameworkCore.Storage;

namespace FleetFlow.Service.Services.Warehouses
{
    public class ProductInventoryAssignmentService : IProductInventoryAssignmentService
    {
        private readonly IRepository<ProductInventoryAssignment> repository;
        private readonly IProductService productService;
        private readonly ILocationService locationService;
        private readonly IInventoryService inventoryService;
        private readonly IMapper mapper;
        public ProductInventoryAssignmentService(IRepository<ProductInventoryAssignment> repository,
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

        public async Task<ProductInventoryAssignmentForResultDto> AddAsync(ProductInventoryAssignmentForCreationDto dto)
        {
            var entity = await this.repository.SelectAsync(p => p.ProductId == dto.ProductId &&
                p.InventoryId == dto.InventoryId &&
                p.LocationId == dto.LocationId);

            if (entity is not null || entity.IsDeleted == false)
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

            var mapped = this.mapper.Map<ProductInventoryAssignment>(dto);
            mapped.CreatedAt = DateTime.UtcNow;
            
            var added = await this.repository.InsertAsync(mapped);
            await this.repository.SaveAsync();

            return this.mapper.Map<ProductInventoryAssignmentForResultDto>(added);
                
        }
        public async Task<ProductInventoryAssignmentForResultDto> AddQuantity(long ProductId, long InventoryId, int amount)
        {
            var model = await this.repository.SelectAsync(x => x.ProductId == ProductId && x.InventoryId == InventoryId);
            if (model is null || model.IsDeleted == true)
                throw new FleetFlowException(404, "Product not found");
            model.Amount += amount;
            await this.repository.SaveAsync();
            return this.mapper.Map<ProductInventoryAssignmentForResultDto>(model);
        }
        public async Task<ProductInventoryAssignmentForResultDto> RemoveQuantity(long ProductId, long InventoryId, int amount)
        {
            var model = await this.repository.SelectAsync(x => x.ProductId == ProductId && x.Id == InventoryId);
            if (model is null || model.IsDeleted == true)
                throw new FleetFlowException(404, "Product not found");
            model.Amount -= amount;
            await this.repository.SaveAsync();
            return this.mapper.Map<ProductInventoryAssignmentForResultDto>(model);
        }
        public async Task<ProductInventoryAssignmentForResultDto> ModifyAsync(long id, ProductInventoryAssignmentForUpdateDto dto)
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
            return this.mapper.Map<ProductInventoryAssignmentForResultDto>(mapped);
        }

        public async Task<IEnumerable<ProductInventoryAssignmentForResultDto>> RetrieveAllAsync(PaginationParams @params)
        {
            var products = await this.repository.SelectAll()
            .Where(u => u.IsDeleted == false)
            .ToPagedList(@params)
            .ToListAsync();

            return mapper.Map<IEnumerable<ProductInventoryAssignmentForResultDto>>(products);
        }
        public async Task<ProductInventoryAssignmentForResultDto> RetrieveByIdAsync(long id)
        {
            var entity = await this.repository.SelectAsync(x => x.Id == id);

            if (entity is null || entity.IsDeleted == true)
                throw new FleetFlowException(404, "Product not found");
            return this.mapper.Map<ProductInventoryAssignmentForResultDto>(entity);
            
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

        public async Task<IEnumerable<ProductInventoryAssignmentForResultDto>> RetrieveProductById(long ProductId)
        {
            var products = await this.repository.SelectAll(x => x.ProductId == ProductId)
            .Where(u => u.IsDeleted == false)
            .ToListAsync();

            return mapper.Map<IEnumerable<ProductInventoryAssignmentForResultDto>>(products);
        }
    }
}
