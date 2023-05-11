using FleetFlow.DAL.IRepositories;
using FleetFlow.DAL.Repositories;
using FleetFlow.Service.Interfaces;
using FleetFlow.Service.Services;

namespace FleetFlow.GraphQL.Extensions
{
    public static class ServiceExtensions
    {
        /// <summary>
        /// Add services
        /// </summary>
        /// <param name="services"></param>
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ICheckoutService, CheckoutService>();
            services.AddScoped<IEmailService, EmailService>();
        }
    }
}
