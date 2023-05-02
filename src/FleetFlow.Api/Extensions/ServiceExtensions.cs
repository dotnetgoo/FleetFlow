using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FleetFlow.DAL.IRepositories;
using FleetFlow.DAL.Repositories;
using FleetFlow.Service.Interfaces;
using FleetFlow.Service.Services;

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
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ILocationService, LocationService>();
        }
    }
}