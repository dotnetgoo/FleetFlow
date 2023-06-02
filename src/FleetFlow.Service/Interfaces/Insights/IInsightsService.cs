using FleetFlow.Service.Models.Insights;

namespace FleetFlow.Service.Interfaces.Insights;

public interface IInsightsService
{
    Task<SellsTableModel> GetSellsTableAsync(InsightsParams parameters);
    Task<IEnumerable<TopProductModel>> GetTopProductsAsync(InsightsParams parameters);
    Task<IEnumerable<TopUserModel>> GetTopUsersAsync(InsightsParams parameters);
}