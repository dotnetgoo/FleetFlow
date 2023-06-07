using Microsoft.AspNetCore.Http;

namespace FleetFlow.Service.DTOs.Payments;

public class PaymentAddDto
{
    public IFormFile File { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public long UserId { get; set; }
    public long OrderId { get; set; }
    public bool IsAdmin { get; set; }
}