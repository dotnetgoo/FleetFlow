using FleetFlow.DAL.IRepositories;
using FleetFlow.DAL.Repositories;
using FleetFlow.GraphQL.Mutations;
using FleetFlow.GraphQL.Queries;
using FleetFlow.Service.Interfaces.Addresses;
using FleetFlow.Service.Interfaces.Attachments;
using FleetFlow.Service.Interfaces.Authorizations;
using FleetFlow.Service.Interfaces.Insights;
using FleetFlow.Service.Interfaces.Orders;
using FleetFlow.Service.Interfaces.Products;
using FleetFlow.Service.Interfaces.UserQuestions;
using FleetFlow.Service.Interfaces.Users;
using FleetFlow.Service.Interfaces.Warehouses;
using FleetFlow.Service.Services.Addresses;
using FleetFlow.Service.Services.Attachments;
using FleetFlow.Service.Services.Authorizations;
using FleetFlow.Service.Services.Insights;
using FleetFlow.Service.Services.Orders;
using FleetFlow.Service.Services.Products;
using FleetFlow.Service.Services.Questions;
using FleetFlow.Service.Services.UserQuestions;
using FleetFlow.Service.Services.Users;
using FleetFlow.Service.Services.Warehouses;
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
            services.AddScoped<IInsightsService, InsightsService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IAttachmentService, AttachmentService>();
            services.AddScoped<IFeedbackService, FeedbackService>();
            services.AddScoped<IPermissionService, PermissionService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IOrderActionService, OrderActionService>();
            services.AddScoped<IDiscountService, DiscountService>();
            services.AddScoped<IRolePermissionService, RolePermissionService>();
            services.AddScoped<IInventoryLogService, InventoryLogService>();
            services.AddScoped<IInventoryService, InventoryService>();
            services.AddScoped<IProductInventoryService, ProductInventoryService>();
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IAnswerService, AnswerService>();
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

                //.AddTypes(typeof(UserType), typeof(UserRoleEnumType))
                .AddType<UploadType>();
        }
    }
}
