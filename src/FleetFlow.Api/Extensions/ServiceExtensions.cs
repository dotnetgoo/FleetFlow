using FleetFlow.DAL.IRepositories;
using FleetFlow.DAL.Repositories;
using FleetFlow.Service.Interfaces.Addresses;
using FleetFlow.Service.Interfaces.Attachments;
using FleetFlow.Service.Interfaces.Authorizations;
using FleetFlow.Service.Interfaces.Bonuses;
using FleetFlow.Service.Interfaces.Commons;
using FleetFlow.Service.Interfaces.Insights;
using FleetFlow.Service.Interfaces.Orders;
using FleetFlow.Service.Interfaces.Products;
using FleetFlow.Service.Interfaces.Staffs;
using FleetFlow.Service.Interfaces.UserQuestions;
using FleetFlow.Service.Interfaces.Users;
using FleetFlow.Service.Interfaces.Warehouses;
using FleetFlow.Service.Services.Addresses;
using FleetFlow.Service.Services.Attachments;
using FleetFlow.Service.Services.Authorizations;
using FleetFlow.Service.Services.Bonuses;
using FleetFlow.Service.Services.Commons;
using FleetFlow.Service.Services.Insights;
using FleetFlow.Service.Services.Orders;
using FleetFlow.Service.Services.Products;
using FleetFlow.Service.Services.Questions;
using FleetFlow.Service.Services.Staffs;
using FleetFlow.Service.Services.UserQuestions;
using FleetFlow.Service.Services.Users;
using FleetFlow.Service.Services.Warehouses;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;


namespace FleetFlow.Api.Extensions
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

            // Addresses
            services.AddScoped<IAddressService, AddressService>();

            // Attachments
            services.AddScoped<IAttachmentService, AttachmentService>();

            // Authorizations
            services.AddScoped<IPermissionService, PermissionService>();
            services.AddScoped<IRolePermissionService, RolePermissionService>();
            services.AddScoped<IRoleService, RoleService>();

            // Insights
            services.AddScoped<IInsightsService, InsightsService>();

            // Orders
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<ICheckoutService, CheckoutService>();
            services.AddScoped<IFeedbackService, FeedbackService>();
            services.AddScoped<IOrderActionService, OrderActionService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IPaymentService, PaymentService>();

            // Products
            services.AddScoped<IDiscountService, DiscountService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductCategoryService, ProductCategoryService>();

            // Questions
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IAnswerService, AnswerService>();

            // Users
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IUserService, UserService>();

            // Warehouses
            services.AddScoped<IInventoryLogService, InventoryLogService>();
            services.AddScoped<IInventoryService, InventoryService>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<IProductInventoryService, ProductInventoryService>();

            //Staff
            services.AddScoped<IStaffService, StaffService>();

            services.AddScoped<IRegionService, RegionService>();
            services.AddScoped<IDistrictService, DistrictService>();

            //Bonus
            services.AddScoped<IBonusService, BonusService>();
            services.AddScoped<IBonusSettingService, BonusSettingService>();

        }

        /// <summary>
        /// Add JWT credentials from appsettings.json and configure it
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void AddJwtService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = configuration["Jwt:Issuer"],
                    ValidAudience = configuration["JWT:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"])),
                    ClockSkew = TimeSpan.Zero
                };
            });
        }

        /// <summary>
        /// Configure swagger generation and auth buttons
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(setup =>
            {
                // Include 'SecurityScheme' to use JWT Authentication
                var jwtSecurityScheme = new OpenApiSecurityScheme
                {
                    BearerFormat = "JWT",
                    Name = "JWT Authentication",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = JwtBearerDefaults.AuthenticationScheme,
                    Description = "Put **_ONLY_** your JWT Bearer token on textbox below!",

                    Reference = new OpenApiReference
                    {
                        Id = JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }
                };

                setup.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);

                setup.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    { jwtSecurityScheme, Array.Empty<string>() }
                });
            });
        }
    }
}