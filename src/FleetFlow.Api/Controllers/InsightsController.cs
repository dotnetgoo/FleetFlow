using FleetFlow.Service.Interfaces.Insights;
using FleetFlow.Service.Models.Insights;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers;



public class InsightsController : RestfulSense
{
    private IInsightsService insightsService;

    public InsightsController(IInsightsService insightsService)
    {
        this.insightsService = insightsService;
    }

    [HttpGet("sells-table")]
    public async ValueTask<IActionResult> GetSellsTable([FromQuery] InsightsParams parameters)
        => Ok(await this.insightsService.GetSellsTableAsync(parameters));

    [HttpGet("top-users")]
    public async ValueTask<IActionResult> GetTopUsers([FromQuery] InsightsParams parameters)
        => Ok(await this.insightsService.GetTopUsersAsync(parameters));

    [HttpGet("top-products")]
    public async ValueTask<IActionResult> GetTopProductsTable([FromQuery] InsightsParams parameters)
        => Ok(await this.insightsService.GetTopProductsAsync(parameters));
}
