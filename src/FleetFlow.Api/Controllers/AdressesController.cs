using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressesController : ControllerBase
    {
        private readonly IAddressService addressService;

        public AdressesController(IAddressService addressService)
        {
            this.addressService = addressService;
        }

        /// <summary>
        /// Creates new address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        [HttpPost]
        public async ValueTask<IActionResult> PostAsync([FromBody] AddressForCreationDto address)
            => Ok(await this.addressService.AddAsync(address));

        /// <summary>
        /// gets address by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async ValueTask<IActionResult> GetByIdAsync(long id)
            => Ok(await this.addressService.GetByIdAsync(id));

        /// <summary>
        /// gets all addresses in db in paginated form
        /// </summary>
        /// <param name="params"></param>
        /// <returns></returns>
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
            => Ok(await this.addressService.GetAllAsync(@params));

        [HttpPut("{id}")]
        public async ValueTask<IActionResult> PutAsync(long id, AddressForCreationDto dto)
            => Ok(await this.addressService.UpdateByIdAsync(id, dto));
    }
}
