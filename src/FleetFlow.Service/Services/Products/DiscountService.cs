using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Products;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Discounts;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.Products;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.Products;

public class DiscountService : IDiscountService
{
    private readonly IMapper mapper;
    private readonly IRepository<Product> productRepository;
    private readonly IRepository<Discount> discountRepository;
    public DiscountService(IMapper mapper,
        IRepository<Product> productRepository,
        IRepository<Discount> discountRepository)
    {
        this.mapper = mapper;
        this.productRepository = productRepository;
        this.discountRepository = discountRepository;
    }

    public async Task<DiscountResultDto> AddAsync(DiscountCreationDto dto)
    {
        if (dto.Amount < 1 || dto.Amount > 100)
            throw new FleetFlowException(401, "PercentageToCheapen must be between 1 and 100.");

        var product = await this.productRepository.SelectAsync(t => t.Id == dto.ProductId && !t.IsDeleted);
        if (product is null)
            throw new FleetFlowException(404, "Product is not found.");

        var discounts = await this.discountRepository.SelectAll(t => t.ProductId == dto.ProductId)
            .Where(d => d.State == DiscountState.Active || d.FinishedAt > DateTime.UtcNow)
            .ToListAsync();
        if (discounts.Any())
            throw new FleetFlowException(403, "Discount already exist in this product.");

        var mappedDiscount = this.mapper.Map<Discount>(dto);
        mappedDiscount.PriceInDiscount = product.Price - ((product.Price / 100) * dto.Amount);
        var insertedDiscount = await this.discountRepository.InsertAsync(mappedDiscount);
        await this.discountRepository.SaveAsync();

        return this.mapper.Map<DiscountResultDto>(insertedDiscount);
    }

    public async Task<DiscountResultDto> ModifyAsync(long id, DiscountUpdateDto dto)
    {
        if (dto.Amount < 1 || dto.Amount > 100)
            throw new FleetFlowException(401, "PercentageToCheapen must be between 1 and 100.");

        var product = await this.productRepository.SelectAsync(t => t.Id == dto.ProductId && !t.IsDeleted);
        if (product is null)
            throw new FleetFlowException(404, "Product not found");

        var discount = await this.discountRepository.SelectAsync(t => t.Id == id && !t.IsDeleted);
        if (discount is null)
            throw new FleetFlowException(404, "Discount not found");

        var modifiedDiscount = this.mapper.Map(dto, discount);
        modifiedDiscount.PriceInDiscount = product.Price - ((product.Price / 100) * dto.Amount);
        modifiedDiscount.UpdatedAt = DateTime.UtcNow;
        modifiedDiscount.UpdatedBy = HttpContextHelper.UserId;
        await this.productRepository.SaveAsync();

        return this.mapper.Map<DiscountResultDto>(modifiedDiscount);
    }

    public async Task<IEnumerable<DiscountResultDto>> RetrieveAllAsync(PaginationParams @params, DiscountState? state = null)
    {
        var discountsQuery = this.discountRepository.SelectAll(t => !t.IsDeleted);

        if (state is not null)
            discountsQuery = discountsQuery.Where(d => d.State == state);

        var discounts = await discountsQuery.ToPagedList(@params).ToListAsync();
        return this.mapper.Map<IEnumerable<DiscountResultDto>>(discounts);
    }

    public async Task<DiscountResultDto> RetrieveAsync(long id)
    {
        var discount = await this.discountRepository
            .SelectAsync(t => t.Id == id && !t.IsDeleted && t.State == DiscountState.Active, new string[] { "Product" });
        if (discount is null)
            throw new FleetFlowException(404, "Discount not found");

        return this.mapper.Map<DiscountResultDto>(discount);
    }

    public async Task<bool> StopAsync(long id)
    {
        var discount = await this.discountRepository.SelectAsync(t => t.Id == id && !t.IsDeleted);
        if (discount is null)
            throw new FleetFlowException(404, "Discount not found");

        discount.State = DiscountState.UnexpectedlyFinished;
        discount.FinishedAt = DateTime.UtcNow;
        discount.UpdatedAt = DateTime.UtcNow;
        discount.UpdatedBy = HttpContextHelper.UserId;
        await this.discountRepository.SaveAsync();

        return true;
    }

    public async Task<bool> StopByProductIdAsync(long productId)
    {
        var discount = await this.discountRepository.SelectAll(d => !d.IsDeleted && d.ProductId == productId)
            .OrderBy(t => t.Id)
            .LastOrDefaultAsync();
        if (discount is null)
            throw new FleetFlowException(404, "Discount not found");

        discount.State = DiscountState.UnexpectedlyFinished;
        discount.FinishedAt = DateTime.UtcNow;
        discount.UpdatedAt = DateTime.UtcNow;
        discount.UpdatedBy = HttpContextHelper.UserId;
        await this.discountRepository.SaveAsync();

        return true;

    }
}