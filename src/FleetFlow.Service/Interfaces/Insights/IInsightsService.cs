using FleetFlow.Service.Models.Insights;

namespace FleetFlow.Service.Interfaces.Insights;

public interface IInsightsService
{
    Task<SellsTableModel> GetSellsTableAsync(DateTime from, DateTime to);
    Task<IEnumerable<TopProductModel>> GetTopProducts(DateTime from, DateTime to, int top = 10);
    Task<IEnumerable<TopUserModel>> GetTopUsers(DateTime from, DateTime to, int top = 10);
}