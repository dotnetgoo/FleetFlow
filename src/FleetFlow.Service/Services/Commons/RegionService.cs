using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Addresses;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.Commons;
using FleetFlow.Service.Services.Commons.Models;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace FleetFlow.Service.Services.Commons;

public class RegionService : IRegionService
{
    private readonly IRepository<Region> regionRepository;
    private readonly IMapper mapper;
    public RegionService(IRepository<Region> regionRepository, IMapper mapper)
    {
        this.regionRepository = regionRepository;
        this.mapper = mapper;
    }

    public async Task<IEnumerable<RegionResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var regions = await regionRepository.SelectAll()
            .ToPagedList(@params)
            .ToListAsync();

        return mapper.Map<IEnumerable<RegionResultDto>>(regions);
    }

    public async ValueTask<RegionResultDto> RetrieveAsync(long id)
    {
        Region region = await regionRepository.SelectAsync(t => t.Id == id);
        if (region is null)
            throw new FleetFlowException(404, "Region is not found");

        return mapper.Map<RegionResultDto>(region);
    }

    public async ValueTask SaveToDatabase()
    {
        string path = EnvironmentHelper.RegionPath;
        string json = File.ReadAllText(path);
        var regions = JsonConvert.DeserializeObject<IEnumerable<RegionModel>>(json);
        foreach (var item in regions)
        {
            var region = new Region();
            region.Id = long.Parse(item.Id);
            region.NameUz = item.NameUz;
            region.NameRu = item.NameRu;

            await regionRepository.InsertAsync(region);
        }
        await regionRepository.SaveAsync();
    }
}
