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
        /// <summary>
        /// Add Asnwer for the given question
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost("answer")]
        public async ValueTask<IActionResult> AddAsnwerAsync([FromBody] AnswerForCreationDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.answerService.AddAsync(dto)
            });

        /// <summary>
        /// Delete Answer by id from database
        /// </summary>
        /// <param name="answerId"></param>
        /// <returns></returns>
        [HttpDelete("{id:long}")]
        public async ValueTask<IActionResult> DeleteAnswerAsync([FromRoute(Name = "id")] long answerId)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.answerService.DeleteByIdAsync(answerId)
            });

        /// <summary>
        /// Get Answer by id
        /// </summary>
        /// <param name="answerId"></param>
        /// <returns></returns>
        [HttpGet("{id:long}")]
        public async ValueTask<IActionResult> GetByIdAsync([FromRoute(Name = "id")] long answerId)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.answerService.GetByIdAsync(answerId)
            });

        /// <summary>
        /// Get All Answers
        /// </summary>
        /// <param name="params"></param>
        /// <returns></returns>
        [HttpGet("answers")]
        public async ValueTask<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.answerService.GetAllAsync(@params)
            });

        /// <summary>
        /// Get All by AdminId
        /// </summary>
        /// <param name="params"></param>
        /// <param name="adminId"></param>
        /// <returns></returns>
        [HttpGet("admin-id")]
        public async ValueTask<IActionResult> GetAllByAdminIdAsync([FromQuery] PaginationParams @params, long adminId)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.answerService.GetAllByAdminIdAsync(@params, adminId)
            });

        /// <summary>
        /// Get All by UserId
        /// </summary>
        /// <param name="params"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("user-id")]
        public async ValueTask<IActionResult> GetAllByUserIdAsync([FromQuery] PaginationParams @params, long userId)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.answerService.GetAllByUserIdAsync(@params, userId)
            });

        /// <summary>
        /// Edit Answer by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut("{id:long}")]
        public async ValueTask<IActionResult> UpdateAnswerAsync([FromRoute]long id, AnswerForCreationDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.answerService.UpdateByIdAsync(id, dto)
            });
    }
}