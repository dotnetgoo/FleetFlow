using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Products;
using FleetFlow.Service.DTOs.Product;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.Products;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.Products;

public class ProductService : IProductService
{
    private readonly IRepository<Product> productRepository;
    private readonly IMapper mapper;

    public ProductService(IMapper mapper, IRepository<Product> productRepository)
    {
        this.mapper = mapper;
        this.productRepository = productRepository;
    }
    public async Task<ProductForResultDto> AddAsync(ProductForCreationDto dto)
    {
        var product = await productRepository.SelectAsync(srn => srn.Serial == dto.Serial);
        if (product is not null && !product.IsDeleted)
            throw new FleetFlowException(409, "Product Already exists");

        var mappedProduct = mapper.Map<Product>(dto);
        mappedProduct.CreatedAt = DateTime.UtcNow;
        var addedProduct = await productRepository.InsertAsync(mappedProduct);

        await productRepository.SaveAsync();

        return mapper.Map<ProductForResultDto>(addedProduct);
    }
    public async Task<bool> RemoveAsync(long id)
    {

        var product = await productRepository.SelectAsync(p => p.Id == id);
        if (product is null || product.IsDeleted)
            throw new FleetFlowException(404, "Couldn't find product for this given Id");

        await productRepository.DeleteAsync(p => p.Id == id);
        product.DeletedBy = HttpContextHelper.UserId;
        await productRepository.SaveAsync();

        return true;
    }
    public async Task<IEnumerable<ProductForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var products = await productRepository.SelectAll()
            .Where(p => !p.IsDeleted)
            .ToPagedList(@params)
            .ToListAsync();

        return mapper.Map<IEnumerable<ProductForResultDto>>(products);

    }
    public async Task<ProductForResultDto> RetrieveByIdAsync(long id)
    {
        var product = await productRepository.SelectAsync(p => p.Id == id);

        if (product is null || product.IsDeleted)
            throw new FleetFlowException(404, "Product Not Found");

        return mapper.Map<ProductForResultDto>(product);
    }
    public async Task<ProductForResultDto> ModifyAsync(long id, ProductForCreationDto dto)
    {
        var product = await productRepository.SelectAsync(p => p.Id == id);
        if (product is null || product.IsDeleted)
            throw new FleetFlowException(404, "Couldn't found product for given Id");

        var modifiedProduct = mapper.Map(dto, product);
        modifiedProduct.UpdatedAt = DateTime.UtcNow;
        modifiedProduct.UpdatedBy = HttpContextHelper.UserId;

        await productRepository.SaveAsync();

        return mapper.Map<ProductForResultDto>(modifiedProduct);
    }
}
