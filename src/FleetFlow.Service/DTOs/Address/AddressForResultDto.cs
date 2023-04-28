using FleetFlow.Domain.Commons;
using System.ComponentModel;

namespace FleetFlow.Service.DTOs.Address;

public class AddressForResultDto : Auditable
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    [DisplayName("Zip Code")]
    public string ZipCode { get; set; }
    public string Country { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}
