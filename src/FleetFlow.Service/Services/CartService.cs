using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs.Carts;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Interfaces;
using FleetFlow.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.Services
{
    public class CartService : ICartService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Cart> cartRepository;
        private readonly IRepository<Product> productRepository;
        private readonly IRepository<CartItem> cartItemRepository;

        public CartService(IRepository<Product> productRepository, 
            IRepository<Cart> cartRepository, 
            IRepository<CartItem> cartItemRepository,
            IMapper mapper)
        {
            this.mapper = mapper;
            this.cartRepository = cartRepository;
            this.productRepository = productRepository;
            this.cartItemRepository = cartItemRepository;
        }

        public async ValueTask<object> AddItemAsync(long productId, int amount)
        {

            var product = await this.productRepository.SelectAsync(u => u.Id == productId && !u.IsDeleted);

            if (product is null)
                throw new FleetFlowException(404, "Product not found");

            // check for enough amount of product in warehouse
            // TODO:

            // create new cart item
            var cart = await this.cartRepository.SelectAsync(cart => cart.UserId == HttpContextHelper.UserId);
            if (cart is null)
                throw new FleetFlowException(404, "Cart not found");

            var cartItem = new CartItem
            {
                Amount = amount,
                CartId = cart.Id,
                ProductId = productId
            };
            var insertedCartItem = this.cartItemRepository.InsertAsync(cartItem);
            await this.cartItemRepository.SaveAsync();

            return this.mapper.Map<CartItemResultDto>(insertedCartItem);
        }

        public ValueTask<object> RemoveItemAsync(long cartItemId)
        {
            throw new NotImplementedException();
        }

        public ValueTask<object> UpdateItemAsync(long cartItemId, int amount)
        {
            throw new NotImplementedException();
        }
    }
}
