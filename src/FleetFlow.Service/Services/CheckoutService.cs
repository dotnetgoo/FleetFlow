using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.Interfaces;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.Services
{
    public class CheckoutService : ICheckoutService
    {
        private readonly IAddressService addressService;
        private readonly IRepository<Order> orderRepository;
        public CheckoutService(IRepository<Order> orderRepository, IAddressService addressService)
        {
            this.orderRepository = orderRepository;
            this.addressService = addressService;
        }

        public ValueTask<AddressForResultDto> AssignAddressAsync(AddressForCreationDto addressDto)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<AddressForResultDto> RetrieveLastAddressAsync()
        {
            var order = await this.orderRepository.SelectAll(o => o.UserId == HttpContextHelper.UserId)
                .LastOrDefaultAsync();
            
            return await this.addressService.GetByIdAsync(order?.AddressId ?? 0);
        }
    }
}
