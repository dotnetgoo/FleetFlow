using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Feedbacks;
using FleetFlow.Service.Interfaces.Orders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers;
public class FeedbackController : RestfulSense
{
    private readonly IFeedbackService feedbackService;

    public FeedbackController(IFeedbackService feedbackService)
    {
        this.feedbackService = feedbackService;
    }
    [HttpPost("feedback")]
    public async ValueTask<IActionResult> PostAsync(FeedbackCreationDto dto)
            => Ok(new Response()
            {
                Code = 200,
                Message = "OK",
                Data = await this.feedbackService.AddAsync(dto)
            });

    [HttpDelete("{id}")]
    public async ValueTask<IActionResult> DeleteAsync([FromRoute] long id)
        => Ok(new Response()
        {
            Code = 200,
            Message = "OK",
            Data = await this.feedbackService.DeleteAsync(id)
        });

    [HttpPatch("{id}")]
    public async ValueTask<IActionResult> MarkAsReadAsync([FromRoute] long id)
        => Ok(new Response()
        {
            Code= 200,
            Message = "OK",
            Data = await this.feedbackService.MarkAsReadAsync(id)
        });

    [HttpGet("{id}")]
    public async ValueTask<IActionResult> GetAsync([FromRoute] long id)
        => Ok(new Response()
        {
            Code = 200,
            Message = "OK",
            Data = await this.feedbackService.RetrieveAsync(id)
        });

    [HttpGet("feedbacks")]
    public async ValueTask<IActionResult> GetAllByStatusAsync([FromQuery] PaginationParams @params,
            [FromQuery] FeedbackStatus status = FeedbackStatus.NotSeen)
    {
        return Ok(new Response()
        {
            Code = 200,
            Message = "OK",
            Data = await this.feedbackService.RetriveAllByStatusAsync(@params, status)
        });
    }

    [HttpGet("{id}")]
    public async ValueTask<IActionResult> GetAllByClientIdAsync([FromQuery] long id)
    {
        return Ok(new Response()
        {
            Code = 200,
            Message = "OK",
            Data = await this.GetAllByClientIdAsync(id)
        });
    }
}
