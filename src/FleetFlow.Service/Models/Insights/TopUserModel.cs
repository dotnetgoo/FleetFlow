using FleetFlow.Service.DTOs.User;

namespace FleetFlow.Service.Models.Insights;

public class TopUserModel
{
    public long UserId { get; set; }
    public UserForResultDto User { get; set; }
    public int AllOrdersNumber { get; set; }
    public decimal SumOfAllOrders { get; set; }

    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public int Top { get; set; }
}