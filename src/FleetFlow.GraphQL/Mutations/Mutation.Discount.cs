using FleetFlow.Service.DTOs.Discounts;
using FleetFlow.Service.Interfaces.Products;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<DiscountResultDto> AddDiscountAsync([Service] IDiscountService discountService,
            DiscountCreationDto discount)
        {
            return await discountService.AddAsync(discount);
        }

        public async ValueTask<DiscountResultDto> UpdateDiscountAsync([Service] IDiscountService discountService,
            long id,
            DiscountUpdateDto discount)
        {
            return await discountService.ModifyAsync(id, discount);
        }

        public async ValueTask<bool> StopDiscountAsync([Service] IDiscountService discountService,
            long id)
        {
            return await discountService.StopAsync(id);
        }

        public async ValueTask<bool> StopDiscountByProductIdAsync([Service] IDiscountService discountService,
            long productId)
        {
            return await discountService.StopByProductIdAsync(productId);
        }
    }
}
