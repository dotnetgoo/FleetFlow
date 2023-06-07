using AutoMapper;
using FleetFlow.Shared.Helpers;
using FleetFlow.Domain.Entities;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Service.DTOs.Carts;
using FleetFlow.Service.Exceptions;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Products;
using FleetFlow.Service.Interfaces.Orders;

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
            Amount = dto.Amount,
            CartId = cart.Id,
            ProductId = dto.ProductId,
            AmountTotal = product.Price * dto.Amount,
        };
        var insertedCartItem = await cartItemRepository.InsertAsync(cartItem);
        await cartItemRepository.SaveAsync();

        return mapper.Map<CartItemResultDto>(insertedCartItem);
    }

    public ValueTask<CartItemResultDto> ModifyItemAsync(CartItemUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> RemoveItemAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<CartResultDto> RetrieveByClientIdAsync(long clientId)
    {
        throw new NotImplementedException();
    }

    public ValueTask<IEnumerable<CartItemResultDto>> RetrieveAllAsync(PaginationParams @params, long? clientId)
    {
        throw new NotImplementedException();
    }

    public ValueTask<CartItemResultDto> RetrieveByItemIdAsync(long id)
    {
        throw new NotImplementedException();
    }
}
