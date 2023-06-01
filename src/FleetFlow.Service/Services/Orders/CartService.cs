using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Entities.Products;
using FleetFlow.Domain.Entities.Warehouses;
using FleetFlow.Service.DTOs.Carts;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Interfaces.Orders;
using FleetFlow.Service.Interfaces.Warehouses;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.Orders
{
    public class CartService : ICartService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Cart> cartRepository;
        private readonly IRepository<Product> productRepository;
        private readonly IRepository<CartItem> cartItemRepository;
        private readonly IRepository<ProductInventory> productInventoryAssignmentRepository;

        public CartService(IRepository<Product> productRepository,
            IRepository<Cart> cartRepository,
            IRepository<CartItem> cartItemRepository,
            IMapper mapper,
            IRepository<ProductInventory> productInventoryAssignment)
        {
            this.mapper = mapper;
            this.cartRepository = cartRepository;
            this.productRepository = productRepository;
            this.cartItemRepository = cartItemRepository;
            this.productInventoryAssignmentRepository = productInventoryAssignment;
        }

        public async ValueTask<CartItemResultDto> AddItemAsync(CartItemCreationDto dto)
        {
            var product = await productRepository.SelectAsync(u => u.Id == dto.ProductId && !u.IsDeleted);

            if (product is null)
                throw new FleetFlowException(404, "Product not found");

            // check for enough amount of product in warehouse
            // TODO:
            var productInventories = await productInventoryAssignmentRepository.SelectAll(p => p.ProductId == dto.ProductId,
                new string[] { "Location", "Inventory" }).ToListAsync();
            if (!productInventories.Any())
                throw new FleetFlowException(400, "Product is not exists!");

            var productInventory = productInventories?.FirstOrDefault(p => p.Amount >= dto.Amount);
            if (productInventory is null)
                throw new FleetFlowException(400, "Product is not enough!");


            // create new cart item
            var cart = await cartRepository.SelectAsync(cart => cart.UserId == HttpContextHelper.UserId);
            if (cart is null)
                throw new FleetFlowException(404, "Cart not found");

            var cartItem = new CartItem
            {
                Amount = dto.Amount,
                CartId = cart.Id,
                ProductId = dto.ProductId,
                ProductInventoryAssignmentId = productInventory.Id
            };
            var insertedCartItem = await cartItemRepository.InsertAsync(cartItem);
            await cartItemRepository.SaveAsync();

            return mapper.Map<CartItemResultDto>(insertedCartItem);
        }

        public async ValueTask<object> RemoveItemAsync(long cartItemId)
        {
            // Checking of is exist the CartItem on this cartItemId 
            var cartItem = await cartItemRepository.SelectAsync(cartItem => cartItem.Id == cartItemId);
            if (cartItem is null)
                throw new FleetFlowException(404, "CartItem not found");

            // Removing existing cartItem 
            await cartItemRepository.DeleteAsync(cartItem => cartItem.Id == cartItemId);
            await cartItemRepository.SaveAsync();

            return true;
        }

        public ValueTask<IEnumerable<CartItemResultDto>> RetrieveAllAsync(PaginationParams @params, long clientId)
        {
            throw new NotImplementedException();
        }

        public ValueTask<CartResultDto> RetrieveByClientIdAsync(long clientId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update item of Cart
        /// </summary>
        /// <param name="cartItemId"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        /// <exception cref="FleetFlowException"></exception>
        public async ValueTask<object> UpdateItemAsync(long itemId, int amount)
        {
            // checking of is exist the CartItem on this cartItemId 
            var cartItem = await cartItemRepository.SelectAsync(cartItem => cartItem.Id == itemId);
            if (cartItem is null)
                throw new FleetFlowException(404, "CartItem not found");

            // checking for the amount is not must less than 0
            if (amount <= 0)
                throw new FleetFlowException(400, "Amount is not valid");

            cartItem.Amount = amount;

            cartItem = cartItemRepository.Update(cartItem);
            await cartItemRepository.SaveAsync();

            return cartItem;
        }
    }
}
