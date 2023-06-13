using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.Interfaces.Bonuses;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class BonusesController : RestfulSense
    {
        private readonly IBonusService bonusService;

        public BonusesController(IBonusService bonusService)
        {
            this.bonusService = bonusService;
        }

        [HttpGet("{id:long}")]
        public async ValueTask<IActionResult> GetByIdAsync(long id) =>
            Ok(new Response
            {
                Code = 200,
                Message = "Ok",
                Data = await this.bonusService.RetrieveByIdAsyn(id)
            });


        [HttpGet("bonuses")]
        public async ValueTask<IActionResult> GetAllAsync(PaginationParams @params) =>
           Ok(new Response
           {
               Code = 200,
               Message = "Ok",
               Data = await this.bonusService.RetrieveAll(@params)
           });

        [HttpGet("user-bonus")]
        public async ValueTask<IActionResult> GetUserBonus()
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.bonusService.RetrieveUserBonus()
            });
    }
}
