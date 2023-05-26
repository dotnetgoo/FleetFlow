using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Questions;
using FleetFlow.Service.Interfaces.UserQuestions;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class AnswerController : RestfulSense
    {
        private readonly IAnswerService answerService;

        public AnswerController(IAnswerService answerService)
        {
            this.answerService = answerService;
        }
        [HttpPost]
        public async ValueTask<IActionResult> AddAsnwerAsync([FromBody] AnswerForCreationDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.answerService.AddAsync(dto)
            });

        [HttpDelete("{id}")]
        public async ValueTask<IActionResult> DeleteAnswerAsync([FromRoute(Name = "id")] long answerId)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.answerService.DeleteByIdAsync(answerId)
            });

        [HttpGet("{id}")]
        public async ValueTask<IActionResult> GetByIdAsync([FromRoute(Name = "id")] long answerId)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.answerService.GetByIdAsync(answerId)
            });

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.answerService.GetAllAsync(@params)
            });

        [HttpGet("admin/{id}")]
        public async ValueTask<IActionResult> GetAllByAdminIdAsync([FromQuery] PaginationParams @params, long adminId)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.answerService.GetAllByAdminIdAsync(@params, adminId)
            });

        [HttpGet("user/{id}")]
        public async ValueTask<IActionResult> GetAllByUserIdAsync([FromQuery] PaginationParams @params, long userId)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.answerService.GetAllByUserIdAsync(@params, userId)
            });

        [HttpPut]
        public async ValueTask<IActionResult> UpdateAnswerAsync(long id, AnswerForCreationDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.answerService.UpdateByIdAsync(id, dto)
            });
    }
}