using AutoMapper;
using FleetFlow.Domain.Enums;
using FleetFlow.Shared.Helpers;
using FleetFlow.Domain.Entities;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Interfaces;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Orders;

namespace FleetFlow.Service.Services
{
    public class OrderService : IOrderService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Cart> cartRepository;
        private readonly IRepository<Order> orderRepository;
        private readonly IRepository<OrderAction> orderActionRepository;

        public OrderService(IRepository<Order> orderRepository,
            IRepository<OrderAction> orderActionRepository,
            IRepository<Cart> cartRepository,
            IMapper mapper)
        {
            this.orderActionRepository = orderActionRepository;
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
            order.Actions = new List<OrderAction>();
            var createdOrder = await this.orderRepository.InsertAsync(order);
            await this.orderRepository.SaveAsync();

            return this.mapper.Map<OrderResultDto>(createdOrder);
        }

        public async ValueTask<OrderResultDto> CancelAsync(long id)
        {
            var order = await this.orderRepository.SelectAsync(order => !order.IsDeleted && order.Id == id, new string[] { "User", "Actions" });
            if (order is null)
                throw new FleetFlowException(404, "Order is not found");

            if (order.User.Role != UserRole.Admin && order.UserId != HttpContextHelper.UserId)
                throw new FleetFlowException(400, "Invalid operation.");

            // TODO: Add business logic for canceled order.
            // Returning products to warehouse, assignments to workers 

            order.Status = OrderStatus.Cancelled;

            // Creating new order action
            order.Actions.Add(new OrderAction() { Status = OrderStatus.Cancelled });

            await this.orderRepository.SaveAsync();

            var result = this.mapper.Map<OrderResultDto>(order);
            // is this best practice to avoid object cycle?
            result.User.Orders = null;

            return result;
        }

        public ValueTask<bool> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IEnumerable<OrderResultDto>> RetrieveAllAsync(PaginationParams @params, OrderStatus status = OrderStatus.Pending)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IEnumerable<OrderResultDto>> RetrieveAllByClientIdAsync(long clientId)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IEnumerable<OrderResultDto>> RetrieveAllByPhoneAsync(PaginationParams @params, string phone, OrderStatus? status = null)
        {
            throw new NotImplementedException();
        }

        public ValueTask<OrderResultDto> RetrieveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<OrderResultDto> StartPreparingAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
