namespace FleetFlow.Service.DTOs.Address;

public class AddressForCreationDto
{
    public long RegionId { get; set; }
    public long DistrictId { get; set; }
    public string Street { get; set; }
    public string Department { get; set; }
    public string Home { get; set; }
    public string DomofonCode { get; set; }
    public string Floor { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}