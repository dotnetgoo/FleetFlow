using FleetFlow.Service.Interfaces.Insights;
using FleetFlow.Service.Models.Insights;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<SellsTableModel> RetrieveSellsTableAsync([Service] IInsightsService insightsService,
            InsightsParams insightsParams)
        {
            return await insightsService.GetSellsTableAsync(insightsParams);
        }

        public async ValueTask<IEnumerable<TopProductModel>> RetrieveTopProductAsyn([Service] IInsightsService insightsService,
            InsightsParams insightsParams)
        {
            return await insightsService.GetTopProductsAsync(insightsParams);
        }

        public async ValueTask<IEnumerable<TopUserModel>> RetrieveTopUsersAsync([Service] IInsightsService insightsService,
            InsightsParams insightsParams)
        {
            return await insightsService.GetTopUsersAsync(insightsParams);
        }
    }
}
