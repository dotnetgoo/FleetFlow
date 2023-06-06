using FleetFlow.Domain.Enums;

namespace FleetFlow.Service.DTOs.Orders;

public class OrderForCreationDto
{
    public long RegionId { get; set; }
    public long DistrictId { get; set; }
    public long AddressId { get; set; }
    public PaymentType PaymentType { get; set; }
}
