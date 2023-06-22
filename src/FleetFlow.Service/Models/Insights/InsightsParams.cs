namespace FleetFlow.Service.Models.Insights;

public class InsightsParams
{
    public int Top { get; set; } = 10;
    public DateTime From { get; set; } = DateTime.MinValue;
    public DateTime To { get; set; } = DateTime.UtcNow;
}
