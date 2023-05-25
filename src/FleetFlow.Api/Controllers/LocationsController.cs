using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Location;
using FleetFlow.Service.Interfaces.Warehouses;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class LocationsController : RestfulSense
    {
        private readonly ILocationService locationService;
        public LocationsController(ILocationService locationService)
        {
            this.locationService = locationService;
        }

        /// <summary>
        /// Get all location
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await locationService.RetrieveAllAsync(@params)
            });


        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("id")]
        public async ValueTask<IActionResult> GetAsync(long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await locationService.RetrieveByIdAsync(id)
            });

        /// <summary>
        /// Create location
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async ValueTask<IActionResult> PostAsync([FromBody] LocationForCreationDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await locationService.AddAsync(dto)
            });

        /// <summary>
        /// Update location info
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("id")]
        public async ValueTask<ActionResult<LocationForResultDto>> PutAsync(LocationForCreationDto dto, long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await locationService.ModifyAsync(id, dto)
            });

        /// <summary>
        /// Delete by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("id")]
        public async ValueTask<ActionResult<bool>> DeleteAsync(long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await locationService.RemoveAsync(id)
            });
    }
}
