using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Bonuses;

namespace FleetFlow.Service.Interfaces.Bonuses;

public interface IBonusService
{
    ValueTask<BonusResultDto> RetrieveByIdAsyn(long id);
    ValueTask<IEnumerable<BonusResultDto>> RetrieveAll(PaginationParams @params);
    ValueTask<decimal> RetrieveUserBonus();
}