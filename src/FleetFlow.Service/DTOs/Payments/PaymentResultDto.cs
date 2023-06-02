using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.DTOs.User;

namespace FleetFlow.Service.DTOs.Payments;

public class PaymentResultDto
{
    public long Id { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public string FilePath { get; set; }
    public bool IsAdmin { get; set; }
    public PaymentStatus Status { get; set; }
    public UserForResultDto User { get; set; }
    public OrderResultDto Order { get; set; }
}