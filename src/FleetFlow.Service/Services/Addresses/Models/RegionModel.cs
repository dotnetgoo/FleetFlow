using Newtonsoft.Json;

namespace FleetFlow.Service.Services.Addresses.Models;

public class RegionModel
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name_uz")]
    public string NameUz { get; set; }
    
    [JsonProperty("name_uz")]
    public string NameRu { get; set; }
}
