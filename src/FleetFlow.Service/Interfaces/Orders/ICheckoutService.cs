using FleetFlow.Service.DTOs.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.Interfaces.Orders
{
    public interface ICheckoutService
    {
        ValueTask<AddressForResultDto> RetrieveLastAddressAsync();
        ValueTask<AddressForResultDto> AssignAddressAsync(AddressForCreationDto addressDto);
    }
}
