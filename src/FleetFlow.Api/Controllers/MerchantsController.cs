using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Merchant;
using FleetFlow.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MerchantsController : ControllerBase
    {
        private readonly IMerchantService merchantService;
        public MerchantsController(IMerchantService merchantService)
        {
            this.merchantService = merchantService;
        }

        /// <summary>
        /// Get all merchants
        /// </summary>
        /// <param name="params"></param>
        /// <returns></returns>
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync([FromQuery]PaginationParams @params)
            => Ok(await merchantService.RetrieveAllAsync(@params));

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("id")]
        public async ValueTask<IActionResult> GetByIdAsync(long id)
            => Ok(await merchantService.RetrieveByIdAsync(id));

        /// <summary>
        /// Create new merchant
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async ValueTask<ActionResult<MerchantForResultDto>> PostAsync(MerchantForCreationDto dto)
            => Ok(await merchantService.AddAsync(dto));

        /// <summary>
        /// Update merchant info
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut("id")]
        public async ValueTask<ActionResult<MerchantForResultDto>> PutAsync(long id, MerchantForCreationDto dto)
            => Ok(await merchantService.ModifyAsync(id, dto));

        /// <summary>
        /// Delete by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("id")]
        public async ValueTask<ActionResult<bool>> DeleteAsync(long id)
            => Ok(await merchantService.RemoveAsync(id));

    }
}
