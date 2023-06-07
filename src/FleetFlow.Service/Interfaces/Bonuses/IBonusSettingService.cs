using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Bonuses;

namespace FleetFlow.Service.Interfaces.Bonuses;

public interface IBonusSettingService
{
    ValueTask<BonusSettingResultDto> AddAsyn(BonusSettingCreationDto dto);
    ValueTask<BonusSettingResultDto> ModifyAsyn(BonusSettingUpdateDto dto);
    ValueTask<bool> RemoveAsyn(long id);
    ValueTask<BonusSettingResultDto> RetrieveByIdAsyn(long id);
    ValueTask<IEnumerable<BonusSettingResultDto>> RetrieveAll(PaginationParams @params);
}