using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Bonuses;
using FleetFlow.Service.Interfaces.Bonuses;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class BonusSettingsController : RestfulSense
    {
        private readonly IBonusSettingService bonusSettingService;

        public BonusSettingsController(IBonusSettingService bonusSettingService)
        {
            this.bonusSettingService = bonusSettingService;
        }

        [HttpPost]
        public async ValueTask<IActionResult> PostAsync(BonusSettingCreationDto dto) =>
            Ok(new Response()
            {
                Code = 200,
                Message = "Ok",
                Data = await this.bonusSettingService.AddAsyn(dto)
            });


        [HttpPut]
        public async ValueTask<IActionResult> PutAsync(BonusSettingUpdateDto dto) =>
            Ok(new Response()
            {
                Code = 200,
                Message = "Ok",
                Data = await this.bonusSettingService.ModifyAsyn(dto)
            });


        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(long id) =>
            Ok(new Response()
            {
                Code = 200,
                Message = "Ok",
                Data = await this.bonusSettingService.RemoveAsyn(id)
            });


        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync([FromQuery] PaginationParams @params) =>
            Ok(new Response()
            {
                Code = 200,
                Message = "Ok",
                Data = await this.bonusSettingService.RetrieveAll(@params)
            });


        [HttpGet("{id:long}")]
        public async ValueTask<IActionResult> GetById(long id) =>
            Ok(new Response()
            {
                Code = 200,
                Message = "Ok",
                Data = await this.bonusSettingService.RetrieveByIdAsyn(id)
            });
    }
}
