using FleetFlow.Service.DTOs.Discounts;
using FleetFlow.Service.Interfaces.Products;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public ValueTask<DiscountResultDto> AddDiscountAsync([Service] IDiscountService discountService, 
            DiscountCreationDto discount)
        {
            throw new NotImplementedException();
        }

        public ValueTask<DiscountResultDto> UpdateDiscountAsync([Service] IDiscountService discountService, 
            DiscountUpdateDto discountUpdateDto) 
        {
            throw new NotImplementedException(); 
        }

        public ValueTask<bool> StopDiscountAsync([Service] IDiscountService discountService, 
            long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> StopDiscountByClientIdAsync([Service] IDiscountService discountService,
            long clientId)
        {
            throw new NotImplementedException();
        }
    }
}
