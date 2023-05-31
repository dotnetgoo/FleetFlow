using FleetFlow.Api.Extensions;
using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Attachments;
using FleetFlow.Service.DTOs.Feedbacks;
using FleetFlow.Service.Interfaces.Orders;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers;
public class FeedbacksController : RestfulSense
{
    private readonly IFeedbackService feedbackService;

    public FeedbacksController(IFeedbackService feedbackService)
    {
        this.feedbackService = feedbackService;
    }
    [HttpPost("feedback")]
    public async ValueTask<IActionResult> PostAsync([FromForm] List<IFormFile> files, [FromForm] FeedbackCreationDto dto)
    {
        var attachments = new List<AttachmentCreationDto>();
        foreach (var file in files)
        {
            attachments.Add(await file.ToAttachmentAsync());
        }

        return Ok(new Response()
        {
            Code = 200,
            Message = "OK",
            Data = await this.feedbackService.AddAsync(dto, attachments)
        });
    }

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
            Code = 200,
            Message = "OK",
            Data = await this.feedbackService.MarkAsReadAsync(id)
        });

    [HttpGet("{id:long}")]
    public async ValueTask<IActionResult> GetAsync([FromRoute] long id)
        => Ok(new Response()
        {
            Code = 200,
            Message = "OK",
            Data = await this.feedbackService.RetrieveAsync(id)
        });

    [HttpGet("feedbacks")]
    public async ValueTask<IActionResult> GetAllByStatusAsync([FromQuery] PaginationParams @params,
            [FromQuery] FeedbackStatus? status = null)
    {
        return Ok(new Response()
        {
            Code = 200,
            Message = "OK",
            Data = await this.feedbackService.RetriveAllByStatusAsync(@params, status)
        });
    }

    [HttpGet("client-id")]
    public async ValueTask<IActionResult> GetAllByClientIdAsync(long clientId)
    {
        return Ok(new Response()
        {
            Code = 200,
            Message = "OK",
            Data = await this.GetAllByClientIdAsync(clientId)
        });
    }
}
