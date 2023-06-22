using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Bonuses;
using FleetFlow.Service.DTOs.Bonuses;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.Bonuses;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.Bonuses;

public class BonusSettingService : IBonusSettingService
{
    private readonly IMapper mapper;
    private readonly IRepository<BonusSetting> bonusSettingRepository;
    public BonusSettingService(IMapper mapper, IRepository<BonusSetting> bonusSettingRepository)
    {
        this.mapper = mapper;
        this.bonusSettingRepository = bonusSettingRepository;
    }

    public async ValueTask<BonusSettingResultDto> AddAsyn(BonusSettingCreationDto dto)
    {
        var mappedBonusSetting = this.mapper.Map<BonusSetting>(dto);
        mappedBonusSetting.CreatedAt = DateTime.UtcNow;
        var createdBonusSetting = await this.bonusSettingRepository.InsertAsync(mappedBonusSetting);
        await this.bonusSettingRepository.SaveAsync();
        return this.mapper.Map<BonusSettingResultDto>(createdBonusSetting);
    }

    public async ValueTask<BonusSettingResultDto> ModifyAsyn(BonusSettingUpdateDto dto)
    {
        var bonusSetting = await this.bonusSettingRepository.SelectAsync(b => b.Id == dto.Id && !b.IsDeleted);
        if (bonusSetting == null)
            throw new FleetFlowException(404, "Not Found");
        var mappedBonusSetting = this.mapper.Map(dto, bonusSetting);
        mappedBonusSetting.UpdatedBy = HttpContextHelper.UserId;
        mappedBonusSetting.UpdatedAt = DateTime.UtcNow;
        await this.bonusSettingRepository.SaveAsync();
        return this.mapper.Map<BonusSettingResultDto>(mappedBonusSetting);
    }

    public async ValueTask<bool> RemoveAsyn(long id)
    {
        var isDeleted = await this.bonusSettingRepository.DeleteAsync(b => b.Id  == id && !b.IsDeleted);
        if (!isDeleted)
            throw new FleetFlowException(404, "Not Found");
        await this.bonusSettingRepository.SaveAsync();
        return isDeleted;
    }

    public async ValueTask<IEnumerable<BonusSettingResultDto>> RetrieveAll(PaginationParams @params)
    {
        var bonusSettings = this.bonusSettingRepository.SelectAll(b => !b.IsDeleted, includes: new string[] { "Product" });
        var pagedBonusSettings = await bonusSettings.ToPagedList(@params).ToListAsync();
        return this.mapper.Map<IEnumerable<BonusSettingResultDto>>(pagedBonusSettings);
    }

    public async ValueTask<BonusSettingResultDto> RetrieveByIdAsyn(long id)
    {
        var bonusSetting = await this.bonusSettingRepository.SelectAsync(b => b.Id == id && !b.IsDeleted);
        if (bonusSetting is null)
            throw new FleetFlowException(404, "Not Found");
        return this.mapper.Map<BonusSettingResultDto>(bonusSetting);
    }
}
