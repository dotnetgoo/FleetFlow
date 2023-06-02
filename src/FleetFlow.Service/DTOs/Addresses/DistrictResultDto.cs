namespace FleetFlow.Service.DTOs.Address;

public class DistrictResultDto
{
    public long Id { get; set; }
    public string NameUz { get; set; }
    public string NameRu { get; set; }
    public long RegionId { get; set; }
    public RegionResultDto Region { get; set; }
}