using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Discounts;
using FleetFlow.Service.Interfaces.Products;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<DiscountResultDto> GetDiscountByIdAsync([Service] IDiscountService discountService, long id)
        {
            return await discountService.RetrieveAsync(id);
        }

        public async ValueTask<IEnumerable<DiscountResultDto>> GetAllDiscountsAsync([Service] IDiscountService discountService,
            PaginationParams @params)
        {
            return await discountService.RetrieveAllAsync(@params);
        }
    }
}
