using FleetFlow.Service.DTOs.Carts;
using FleetFlow.Service.Interfaces.Orders;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<CartItemResultDto> AddItemAsync([Service] ICartService cartService,
            CartItemCreationDto cartItem)
        {
            return await cartService.AddItemAsync(cartItem);
        }

        public async ValueTask<object> DeleteItemAsync([Service] ICartService cartService,
            long cartItemId)
        {
            return await cartService.RemoveItemAsync(cartItemId);
        }
    }
}
