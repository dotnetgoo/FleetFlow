using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Carts;

namespace FleetFlow.Service.Interfaces.Orders;

public interface ICartService
{
    ValueTask<CartItemResultDto> AddItemAsync(CartItemCreationDto dto);
    ValueTask<CartItemResultDto> ModifyItemAsync(CartItemUpdateDto dto);
    ValueTask<bool> RemoveItemAsync(long id);
    ValueTask<CartItemResultDto> RetrieveByItemIdAsync(long id);
    ValueTask<IEnumerable<CartItemResultDto>> RetrieveAllAsync(PaginationParams @params);
    ValueTask<CartResultDto> RetrieveByClientIdAsync();
}
