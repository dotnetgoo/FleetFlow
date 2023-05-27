using FleetFlow.Service.DTOs.Product;

namespace FleetFlow.Service.Models.Insights;

public class TopProductModel
{
    public long ProductId { get; set; }
    public ProductForResultDto Product { get; set; }
    public int SellsNumber { get; set; }
    public decimal SumOfSells { get; set; }

    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public int Top { get; set; }
}