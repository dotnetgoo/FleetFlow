using FleetFlow.DAL.IRepositories;
using FleetFlow.DAL.Repositories;
using FleetFlow.GraphQL.Mutations;
using FleetFlow.GraphQL.Queries;
using FleetFlow.GraphQL.Types;
using FleetFlow.GraphQL.Types.EnumTypes;
using FleetFlow.Service.Interfaces;
using FleetFlow.Service.Services;
using HotChocolate.Execution.Options;
using HotChocolate.Types.Pagination;

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

        public static void AddGraphQLService(this IServiceCollection services)
        {
            services.AddGraphQLServer()
                .AddAuthorization()
                .AddFiltering()
                .AddSorting()
                .AddErrorFilter(error => error.WithMessage(error?.Exception?.Message ?? error.Message))
                .SetPagingOptions(new PagingOptions
                {
                    MaxPageSize = 100,
                    DefaultPageSize = 20
                })
                .SetRequestOptions(_ => new RequestExecutorOptions { ExecutionTimeout = TimeSpan.FromMinutes(1) })

                .AddQueryType<Query>()
                .AddMutationType<Mutation>()

                .AddTypes(typeof(UserType), typeof(UserRoleEnumType))
                .AddType<UploadType>();
        }
    }
}
