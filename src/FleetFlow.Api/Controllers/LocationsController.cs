﻿using FleetFlow.Service.DTOs;
using FleetFlow.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationsController : ControllerBase
    {
        private readonly IlocationService locationService;
        public LocationsController(IlocationService locationService)
        {
            this.locationService = locationService;
        }

        /// <summary>
        /// Get all location
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            var locations = await locationService.GetAllAsync();
            return Ok(locations);
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Id")]
        public async ValueTask<IActionResult> GetByIdAsync(long id)
            => Ok(await locationService.GetAsync(location => location.Id == id));

        /// <summary>
        /// Create location
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async ValueTask<IActionResult> PostAsync([FromBody]LocationForCreationDto dto)
            => Ok(await locationService.AddAsync(dto));

        /// <summary>
        /// Update location info
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("Id")]
        public async ValueTask<ActionResult<LocationForResultDto>> PutAsync(LocationForCreationDto dto, long id)
            => Ok(await locationService.UpdateAsync(location => location.Id == id, dto));

        /// <summary>
        /// Delete by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("Id")]
        public async ValueTask<ActionResult<bool>> DeleteAsync(long id)
            => Ok(await locationService.DeleteAsync(location => location.Id.Equals(id)));
    }
}