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

public class BonusService : IBonusService
{
    private readonly IMapper mapper;
    private readonly IRepository<Bonus> bonusRepository;
    public BonusService(IRepository<Bonus> bonusRepository, IMapper mapper)
    {
        this.mapper = mapper;
        this.bonusRepository = bonusRepository;
    }

    public async ValueTask<IEnumerable<BonusResultDto>> RetrieveAll(PaginationParams @params)
    {
        var bonuses = this.bonusRepository.SelectAll(b => !b.IsDeleted, includes: new string[] { "User", "Order", "Product" });
        var pagedBonuses = await bonuses.ToPagedList(@params).ToListAsync();

        return this.mapper.Map<IEnumerable<BonusResultDto>>(pagedBonuses);
    }

    public async ValueTask<BonusResultDto> RetrieveByIdAsyn(long id)
    {
        Bonus bonus = await this.bonusRepository.SelectAsync(b => b.Id == id && !b.IsDeleted);
        if (bonus is null)
            throw new FleetFlowException(404, "Bonus is not found");

        return this.mapper.Map<BonusResultDto>(bonus);
    }

    public async ValueTask<decimal> RetrieveUserBonus()
    {
        var bonus = await this.bonusRepository
            .SelectAll()
            .OrderBy(o => o.Id)
            .LastOrDefaultAsync(b => !b.IsDeleted && b.UserId == HttpContextHelper.UserId);
        return (decimal)bonus.Amount;
    }
}