using AutoMapper;
using FleetFlow.Domain.Enums;
using FleetFlow.Shared.Helpers;
using FleetFlow.Domain.Entities;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Service.Exceptions;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.Extentions;
using Microsoft.EntityFrameworkCore;
using FleetFlow.Domain.Entities.Orders;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Service.Interfaces.Orders;
using FleetFlow.Domain.Entities.Authorizations;

namespace FleetFlow.Service.Services.Orders
{
    public class OrderService : IOrderService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Cart> cartRepository;
        private readonly IRepository<Order> orderRepository;
        private readonly IRepository<User> userRepository;
        private readonly IOrderActionService orderActionService;
        public OrderService(IRepository<Order> orderRepository,
            IRepository<Cart> cartRepository,
            IRepository<User> userRepository,
            IMapper mapper,
            IOrderActionService orderActionService)
        {
            this.orderRepository = orderRepository;
            this.cartRepository = cartRepository;
            this.mapper = mapper;
            this.userRepository = userRepository;
            this.orderActionService = orderActionService;
        }

        public async ValueTask<OrderResultDto> AddAsync()
        {
            var httpContext = HttpContextHelper.HttpContext;
            string role = HttpContextHelper.UserRole;
            var cart = await cartRepository.SelectAsync(c => c.UserId == HttpContextHelper.UserId, new string[] { "Items" });
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
            var createdOrder = await orderRepository.InsertAsync(order);
            await orderRepository.SaveAsync();

            return mapper.Map<OrderResultDto>(createdOrder);
        }

        public async ValueTask<OrderResultDto> CancelAsync(long id)
        {
            var order = await orderRepository.SelectAsync(order => !order.IsDeleted && order.Id == id, new string[] { "User", "Actions" });
            if (order is null)
                throw new FleetFlowException(404, "Order is not found");


            //var role = await this.roleRepository.SelectAsync(r => r.Name == "Admin");
            //if (order.User.Role != role && order.UserId != HttpContextHelper.UserId)
            //    throw new FleetFlowException(400, "Invalid operation.");

            // TODO: Add business logic for canceled order.
            // Returning products to warehouse, assignments to workers 

            /* order.Status = OrderStatus.Cancelled;

             // Creating new order action
             order.Actions.Add(new OrderAction() { Status = OrderStatus.Cancelled });

             await orderRepository.SaveAsync();*/

            var result = mapper.Map<OrderResultDto>(await this.orderActionService.CancelledAsync((int)order.Id));
            // is this best practice to avoid object cycle?
            result.User.Orders = null;

            return result;

        }

    /*    public async Task ChangeStatus(long orderId, OrderStatus status)
        {
            var order = await this.orderRepository.SelectAsync(t => t.Id == orderId);
            if (order is null)
                throw new FleetFlowException(404, "");

            order.Id = orderId;
            order.Status = status;
            await orderRepository.SaveAsync();

        }*/


        public async ValueTask<bool> RemoveAsync(long id)
        {
            var isDeleted = await orderRepository.DeleteAsync(order => order.Id == id);
            if (!isDeleted)
                throw new FleetFlowException(404, "Order is not found");

            return isDeleted;
        }

        public async ValueTask<IEnumerable<OrderResultDto>> RetrieveAllAsync(PaginationParams @params, OrderStatus status = OrderStatus.Pending)
        {
            var orders = await orderRepository
                .SelectAll(order => !order.IsDeleted && order.Status == status)
                .ToPagedList(@params)
                .ToListAsync();
            // checking something exists or not
            if (!orders.Any())
                throw new FleetFlowException(400, "No orders found.");

            return mapper.Map<IEnumerable<OrderResultDto>>(orders);
        }

        public async ValueTask<IEnumerable<OrderResultDto>> RetrieveAllByClientIdAsync(long clientId)
        {
            var orders = await orderRepository
                .SelectAll(order => !order.IsDeleted && order.UserId == clientId)
                .ToListAsync();
            // checking something exists or not
            if (!orders.Any())
                throw new FleetFlowException(400, "No orders found.");

            return mapper.Map<IEnumerable<OrderResultDto>>(orders);
        }

        public async ValueTask<IEnumerable<OrderResultDto>> RetrieveAllByPhoneAsync(PaginationParams @params, string phone, OrderStatus? status = null)
        {
            var user = await userRepository.SelectAsync(user => !user.IsDeleted && user.Phone == phone);
            if (user is null)
                throw new FleetFlowException(404, "User is not found");

            var ordersQuery = orderRepository
                .SelectAll(order => !order.IsDeleted && order.UserId == user.Id);
            if (status is not null)
                ordersQuery = ordersQuery.Where(order => order.Status == status);

            ordersQuery = ordersQuery.ToPagedList(@params);

            var orders = await ordersQuery.ToListAsync();

            // checking something exists or not
            if (!orders.Any())
                throw new FleetFlowException(400, "No orders found.");

            return mapper.Map<IEnumerable<OrderResultDto>>(orders);
        }

        public async ValueTask<OrderResultDto> RetrieveAsync(long id)
        {
            Order order = await orderRepository.SelectAsync(order => !order.IsDeleted && order.Id == id, new string[] { "Address", "User" });
            if (order is null)
                throw new FleetFlowException(404, "Order is not found");

            return mapper.Map<OrderResultDto>(order);
        }
    }
}
