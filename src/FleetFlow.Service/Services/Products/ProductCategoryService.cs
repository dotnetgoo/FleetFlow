using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Products;
using FleetFlow.Service.DTOs.Products;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.Products;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.Products;

public class ProductCategoryService : IProductCategoryService
{
    private readonly IMapper mapper;
    private readonly IRepository<ProductCategory> productCategoryRepository;
    public ProductCategoryService(IMapper mapper,
        IRepository<ProductCategory> productCategoryRepository)
    {
        this.mapper = mapper;
        this.productCategoryRepository = productCategoryRepository;
    }

    public async Task<ProductCategoryResultDto> AddAsync(ProductCategoryCreationDto dto)
    {
        var productCategory = await this.productCategoryRepository.SelectAsync(p => p.Name.ToLower() == dto.Name.ToLower()
        && !p.IsDeleted);
        if (productCategory is not null)
            throw new FleetFlowException(401, "Product category already exist.");

        var mappedCategory = this.mapper.Map<ProductCategory>(dto);
        mappedCategory.CreatedAt = DateTime.UtcNow;
        var addedCategory = await this.productCategoryRepository.InsertAsync(mappedCategory);
        await this.productCategoryRepository.SaveAsync();
        return this.mapper.Map<ProductCategoryResultDto>(addedCategory);
    }

    public async Task<ProductCategoryResultDto> ModifyAsync(long id, ProductCategoryUpdateDto dto)
    {
        var category = await this.productCategoryRepository.SelectAsync(p => p.Id == id && !p.IsDeleted);
        if (category is null)
            throw new FleetFlowException(404, "Product Category is not found");

        var modifiedCategory = this.mapper.Map(dto, category);
        modifiedCategory.UpdatedAt = DateTime.UtcNow;
        modifiedCategory.UpdatedBy = HttpContextHelper.UserId;
        await this.productCategoryRepository.SaveAsync();
        return this.mapper.Map<ProductCategoryResultDto>(modifiedCategory);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var category = await this.productCategoryRepository.SelectAsync(p => p.Id == id && !p.IsDeleted);
        if (category is null)
            throw new FleetFlowException(404, "Product Category is not found");

        bool result = await this.productCategoryRepository.DeleteAsync(p => p.Id == id);
        await this.productCategoryRepository.SaveAsync();
        return result;
    }

    public async Task<IEnumerable<ProductCategoryResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var categories = await this.productCategoryRepository
            .SelectAll(p => !p.IsDeleted)
            .ToPagedList(@params)
            .ToListAsync();

        return this.mapper.Map<IEnumerable<ProductCategoryResultDto>>(categories);
    }

    public async Task<ProductCategoryResultDto> RetrieveAsync(long id)
    {
        var category = await this.productCategoryRepository.SelectAsync(p => p.Id == id && !p.IsDeleted);
        if (category is null)
            throw new FleetFlowException(404, "Product Category not found");

        return this.mapper.Map<ProductCategoryResultDto>(category);
    }
}
