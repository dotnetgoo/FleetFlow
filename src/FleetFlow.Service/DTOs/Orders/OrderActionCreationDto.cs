using FleetFlow.Domain.Enums;

namespace FleetFlow.Service.DTOs.Orders;

public class OrderActionCreationDto
{
    public long OrderId { get; set; }
    public DateTime? ApproximateFinishTime { get; set; }
}
