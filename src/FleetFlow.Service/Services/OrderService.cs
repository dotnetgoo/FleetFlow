using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Interfaces;
using FleetFlow.Shared.Helpers;

namespace FleetFlow.Service.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> orderRepository;
        private readonly IRepository<Cart> cartRepository;
        private readonly IMapper mapper;

        public OrderService(IRepository<Order> orderRepository,
            IRepository<Cart> cartRepository,
            IMapper mapper)
        {
            this.orderRepository = orderRepository;
            this.cartRepository = cartRepository;
            this.mapper = mapper;
        }

        public async ValueTask<OrderResultDto> AddAsync()
        {
            var httpContext = HttpContextHelper.HttpContext;
            string role = HttpContextHelper.UserRole;
            var cart = await this.cartRepository.SelectAsync(c => c.UserId == HttpContextHelper.UserId, new string[] { "Items" });
            if (cart == null)
                throw new FleetFlowException(404, "Cart not found");

            // create new order
            var order = new Order()
            {
                UserId = HttpContextHelper.UserId ?? 0,
                OrderItems = new List<OrderItem>()
            };

            // create order items using cart
            foreach (var cartItem in cart.Items)
            {
                order.OrderItems.Add(new OrderItem
                {
                    Amount = cartItem.Amount,
                    ProductId = cartItem.ProductId
                });
            }

            var createdOrder = await this.orderRepository.InsertAsync(order);
            await this.orderRepository.SaveAsync();

            return this.mapper.Map<OrderResultDto>(createdOrder);
        }
    }
}
