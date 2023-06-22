using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Entities.Products;
using FleetFlow.Service.DTOs.Carts;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.Orders;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.Orders;

public class CartService : ICartService
{
    private readonly IMapper mapper;
    private readonly IRepository<Cart> cartRepository;
    private readonly IRepository<Product> productRepository;
    private readonly IRepository<CartItem> cartItemRepository;

    public CartService(
        IMapper mapper,
        IRepository<Cart> cartRepository,
        IRepository<Product> productRepository,
        IRepository<CartItem> cartItemRepository)
    {
        this.mapper = mapper;
        this.cartRepository = cartRepository;
        this.productRepository = productRepository;
        this.cartItemRepository = cartItemRepository;
    }

    public async ValueTask<CartItemResultDto> AddItemAsync(CartItemCreationDto dto)
    {
        var product = await productRepository.SelectAsync(u => u.Id == dto.ProductId && !u.IsDeleted);

        if (product is null)
            throw new FleetFlowException(404, "Product not found");

        // create new cart item
        var cart = await cartRepository.SelectAsync(cart => cart.UserId == HttpContextHelper.UserId);
        if (cart is null)
            throw new FleetFlowException(404, "Cart is not found");

        var cartItem = new CartItem
        {
            CartId = cart.Id,
            Amount = dto.Amount,
            ProductId = dto.ProductId,
            AmountTotal = product.Price * dto.Amount,
        };
        var insertedCartItem = await cartItemRepository.InsertAsync(cartItem);
        await cartItemRepository.SaveAsync();

        return mapper.Map<CartItemResultDto>(insertedCartItem);
    }

    public async ValueTask<CartItemResultDto> ModifyItemAsync(CartItemUpdateDto dto)
    {
        var cartItem = await this.cartItemRepository
            .SelectAsync(item => !item.IsDeleted && !item.IsOrdered && item.Id == dto.Id,
            includes: new string[] { "Product" });
        if (cartItem is null)
            throw new FleetFlowException(404, "Cart item not found");

        cartItem.Amount = dto.Amount;
        cartItem.AmountTotal = cartItem.Product.Price * dto.Amount;
        cartItem.UpdatedBy = HttpContextHelper.UserId;
        cartItem.UpdatedAt = DateTime.UtcNow;
        var result = this.cartItemRepository.Update(cartItem);
        await this.cartItemRepository.SaveAsync();

        return this.mapper.Map<CartItemResultDto>(result);
    }

    public async ValueTask<bool> RemoveItemAsync(long id)
    {
        var cartItem = await this.cartItemRepository
            .SelectAsync(item => !item.IsDeleted && !item.IsOrdered && item.Id == id);
        if (cartItem is null)
            throw new FleetFlowException(404, "Cart item not found");

        cartItem.DeletedBy = HttpContextHelper.UserId;
        bool result = await this.cartItemRepository.DeleteAsync(item => item.Id == id);
        await this.cartItemRepository.SaveAsync();
        return result;
    }

    public async ValueTask<CartResultDto> RetrieveByClientIdAsync()
    {
        var cart = await this.cartRepository
            .SelectAsync(item => !item.IsDeleted && item.UserId == HttpContextHelper.UserId,
            includes: new string[] { "Items" });
        if (cart is null)
            throw new FleetFlowException(404, "Cart item not found.");

        return this.mapper.Map<CartResultDto>(cart);
    }

    public async ValueTask<IEnumerable<CartItemResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var itemsQuery = this.cartItemRepository
            .SelectAll(item => !item.IsDeleted && !item.IsOrdered && item.Cart.UserId == HttpContextHelper.UserId,
            includes: new string[] { "Product" });


        var items = await itemsQuery.ToPagedList(@params).ToListAsync();

        return this.mapper.Map<IEnumerable<CartItemResultDto>>(items);
    }

    public async ValueTask<CartItemResultDto> RetrieveByItemIdAsync(long id)
    {
        var cartItem = await this.cartItemRepository
            .SelectAsync(item => !item.IsDeleted && !item.IsOrdered && item.Id == id,
            includes: new string[] { "Product" });
        if (cartItem is null)
            throw new FleetFlowException(404, "Cart item not found.");

        return this.mapper.Map<CartItemResultDto>(cartItem);
    }
}
