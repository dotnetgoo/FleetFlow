using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Discounts;
using FleetFlow.Service.Interfaces.Products;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public ValueTask<DiscountResultDto> GetDiscountByIdAsync([Service] IDiscountService discountService, long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IEnumerable<DiscountResultDto>> GetAllDiscountsAsync([Service] IDiscountService discountService,
            PaginationParams @params)
        {
            throw new NotImplementedException();
        }
    }
}
