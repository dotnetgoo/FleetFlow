using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.DTOs.Attachments;
using FleetFlow.Service.DTOs.Payments;

namespace FleetFlow.Service.DTOs.Orders;

public class OrderForCreationDto
{
    public long RegionId { get; set; }
    public long DistrictId { get; set; }
    public long AddressId { get; set; }
    public long PaymentId { get; set; }
}
