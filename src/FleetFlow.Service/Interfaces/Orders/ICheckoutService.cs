using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.DTOs.Attachments;
using FleetFlow.Service.DTOs.Carts;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.DTOs.Payments;

namespace FleetFlow.Service.Interfaces.Orders;

public interface ICheckoutService
{
    // 1st step: working with addresses to deliver order
    ValueTask<AddressForResultDto> RetrieveLastAddressAsync();
    ValueTask<AddressForResultDto> AssignAddressAsync(AddressAddDto addressDto);
    ValueTask<PaymentResultDto> PayAsync(PaymentCreationDto dto, AttachmentCreationDto attachment);
    ValueTask<IEnumerable<CartItemResultDto>> GetAllCartItemsAsync();
    ValueTask<OrderResultDto> SaveOrderAsync(OrderForCreationDto orderDto, string promoCode = null);
    ValueTask<OrderResultDto> PayWithBonusAsync(decimal amount);
}