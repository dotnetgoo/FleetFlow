using FleetFlow.Api.Models;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class CheckoutController : RestfulSense
    {
        private readonly ICheckoutService checkoutService;

        public CheckoutController(ICheckoutService checkoutService)
        {
            this.checkoutService = checkoutService;
        }

        [HttpGet("last-address")]
        public async ValueTask<IActionResult> GetLastAddressAsync()
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.checkoutService.RetrieveLastAddressAsync()
            });


        [HttpPost("assign-address")]
        public async ValueTask<IActionResult> AssignAddressAsync([FromBody] AddressForCreationDto addressDto)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.checkoutService.AssignAddressAsync(addressDto)
            });
    }
}
