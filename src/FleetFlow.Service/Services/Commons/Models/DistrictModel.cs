using Newtonsoft.Json;

namespace FleetFlow.Service.Services.Commons.Models;

public class DistrictModel
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("region_id")]
    public string RegionId { get; set; }

    [JsonProperty("name_uz")]
    public string NameUz { get; set; }

    [JsonProperty("name_ru")]
    public string NameRu { get; set; }
}
