namespace FleetFlow.Service.Models.Insights;

public class SellsTableModel
{
    public int NumberOfOrders { get; set; }
    public decimal AvarageOrder { get; set; }
    public decimal SumOfSells { get; set; }
    public int NumberOfOrderedUsers { get; set; }

    public DateTime From { get; set; }
    public DateTime To { get; set; }
}