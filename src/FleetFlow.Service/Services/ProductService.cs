using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces;
using System.Linq.Expressions;

namespace FleetFlow.Service.Services;

public class ProductService : IProductService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;

    public ProductService(IMapper mapper, IUnitOfWork unitOfWork)
    {
        this.mapper = mapper;
        this.unitOfWork = unitOfWork;
    }
    public async Task<ProductForResultDto> AddAsync(ProductForCreationDto dto)
    {
        var product = await this.unitOfWork.Products.SelectAsync(srn => srn.Serial == dto.Serial);
        if (product is not null)
            throw new FleetFlowException(409, "Product Already exists");

        var mappedProduct = this.mapper.Map<Product>(dto);
        mappedProduct.CreatedAt = DateTime.UtcNow;
        var addedProduct = await this.unitOfWork.Products.InsertAsync(mappedProduct);

        await this.unitOfWork.SaveChangesAsync();

        return this.mapper.Map<ProductForResultDto>(addedProduct);
    }
    public async Task<bool> RemoveAsync(long id)
    {
        
        var product = await this.unitOfWork.Products.SelectAsync(p => p.Id == id);
        if (product is null)
			throw new FleetFlowException(404, "Couldn't find product for this given Id");

        await this.unitOfWork.Products.DeleteAsync(p => p.Id == id);

        await this.unitOfWork.SaveChangesAsync();

        return true;
    }
    public async Task<IEnumerable<ProductForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var products = this.unitOfWork.Products.SelectAll()
                                            .ToPagedList(@params).ToList();

        if (products is null)
            throw new FleetFlowException(404, "Product not found");

        return this.mapper.Map<IEnumerable<ProductForResultDto>>(products);

    }
    public async Task<ProductForResultDto> RetrieveByIdAsync(long id)
    {
        var product = await this.unitOfWork.Products.SelectAsync(p => p.Id==id);

        if (product is null)
            throw new FleetFlowException(404, "Product Not Found");

        return this.mapper.Map<ProductForResultDto>(product);
    }
    public async Task<ProductForResultDto> ModifyAsync(long id, ProductForCreationDto dto)
    {
        var product = await this.unitOfWork.Products.SelectAsync(p=>p.Id==id);
        if (product is null)
            throw new FleetFlowException(404, "Couldn't found product for given Id");

        var modifiedProduct = this.mapper.Map(dto, product);
        modifiedProduct.UpdatedAt = DateTime.UtcNow;

        await this.unitOfWork.SaveChangesAsync();

        return this.mapper.Map<ProductForResultDto>(modifiedProduct);
    }
}
