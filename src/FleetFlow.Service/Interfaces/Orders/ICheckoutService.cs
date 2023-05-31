using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.DTOs.Carts;

namespace FleetFlow.Service.Interfaces.Orders;

public interface ICheckoutService
{
    // 1st step: working with addresses to deliver order
    ValueTask<AddressForResultDto> RetrieveLastAddressAsync();
    ValueTask<AddressForResultDto> AssignAddressAsync(AddressForCreationDto addressDto);


}