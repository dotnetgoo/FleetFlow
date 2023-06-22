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

public class DistrictService : IDistrictService
{
    private readonly IMapper mapper;
    private readonly IRepository<Region> regionRepository;
    private readonly IRepository<District> districtRepository;
    public DistrictService(IRepository<District> districtRepository, IMapper mapper, IRepository<Region> regionRepository)
    {
        this.mapper = mapper;
        this.districtRepository = districtRepository;
        this.regionRepository = regionRepository;
    }

    public async ValueTask<IEnumerable<DistrictResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var districts = await districtRepository.SelectAll()
            .ToPagedList(@params)
            .ToListAsync();

        var result = mapper.Map<IEnumerable<DistrictResultDto>>(districts);
        foreach (var item in result)
            item.Region = this.mapper.Map<RegionResultDto>(
                await this.regionRepository.SelectAsync(t => t.Id == item.RegionId));
        return result;
    }

    public async ValueTask<DistrictResultDto> RetrieveAsync(long id)
    {
        District district = await districtRepository.SelectAsync(t => t.Id == id);
        if (district is null)
            throw new FleetFlowException(404, "District is not found");

        return mapper.Map<DistrictResultDto>(district);
    }

    public async ValueTask SaveToDatabase()
    {
        string path = EnvironmentHelper.DistrictPath;
        string json = File.ReadAllText(path);
        var districts = JsonConvert.DeserializeObject<IEnumerable<DistrictModel>>(json);
        foreach (var item in districts)
        {
            var district = new District();
            district.Id = long.Parse(item.Id);
            district.NameUz = item.NameUz;
            district.NameRu = item.NameRu;
            district.RegionId = long.Parse(item.RegionId);

            await districtRepository.InsertAsync(district);
        }
        await districtRepository.SaveAsync();
    }
}
