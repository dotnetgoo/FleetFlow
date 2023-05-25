using FleetFlow.Service.DTOs.Address;

namespace FleetFlow.Service.Interfaces.Orders
{
    public interface ICheckoutService
    {
        ValueTask<AddressForResultDto> RetrieveLastAddressAsync();
        ValueTask<AddressForResultDto> AssignAddressAsync(AddressForCreationDto addressDto);
    }
}
