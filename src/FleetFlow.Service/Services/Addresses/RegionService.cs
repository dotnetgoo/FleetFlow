using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Addresses;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.Interfaces.Orders;
using FleetFlow.Service.Services.Addresses.Models;
using Newtonsoft.Json;

namespace FleetFlow.Service.Services.Addresses;

public class RegionService : IRegionService
{
    private readonly IRepository<Region> regionRepository;
    private readonly 
    public RegionService(IRepository<Region> regionRepository)
    {
        this.regionRepository = regionRepository;
    }

    public List<RegionResultDto> RetrieveAllAsync(PaginationParams @params)
    {

    }

    public ValueTask<RegionResultDto> RetrieveAsync(long id)
    {
        
    }

    public async Task SaveToDatabase()
    {
        var regions = JsonConvert.DeserializeObject<IEnumerable<RegionModel>>(File.ReadAllText(REGION_PATH)).ToArray();
        var region = new Region();
        foreach (var item in regions)
        {
            region.Id = long.Parse(item.Id);
            region.NameUz = item.NameUz;
            region.NameRu = item.NameRu;

            await regionRepository.InsertAsync(region);
        }
    }
}
