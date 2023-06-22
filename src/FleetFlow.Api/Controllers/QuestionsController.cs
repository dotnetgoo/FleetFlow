using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Questions;
using FleetFlow.Service.Interfaces.UserQuestions;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class QuestionsController : RestfulSense
    {
        private readonly IQuestionService questionService;
        public QuestionsController(IQuestionService questionService)
        {
            this.questionService = questionService;
        }

        /// <summary>
        /// Create new question
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async ValueTask<IActionResult> PostAsync([FromBody] QuestionForCreationDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "Success",
                Data = await this.questionService.AddAsync(dto)
            });

        /// <summary>
        /// Delete by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("id")]
        public async ValueTask<IActionResult> DeleteAsync(long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "Success",
                Data = await this.questionService.RemoveAsync(id)
            });

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("id")]
        public async ValueTask<IActionResult> GetByIdAsync(long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "Success",
                Data = await this.questionService.RetrieveByIdAsync(id)
            });

        /// <summary>
        /// Get all questions
        /// </summary>
        /// <param name="params"></param>
        /// <returns></returns>
        [HttpGet("get-list")]
        public async ValueTask<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
            => Ok(new Response
            {
                Code = 200,
                Message = "Success",
                Data = await this.questionService.RetrieveAllAsync(@params)
            });

        /// <summary>
        /// Update question
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut("id")]
        public async ValueTask<IActionResult> PutAsync(long id, [FromBody] string message)
            => Ok(new Response
            {
                Code = 200,
                Message = "Success",
                Data = await this.questionService.ModifyAsync(id, message)
            });

        /// <summary>
        /// Get all by userId
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="params"></param>
        /// <returns></returns>
        [HttpGet("get-list-by-userId")]
        public async ValueTask<IActionResult> GetAllByUserIdAsync(long userId, [FromQuery] PaginationParams @params)
            => Ok(new Response
            {
                Code = 200,
                Message = "Success",
                Data = await this.questionService.RetrieveAllByUserIdAsync(userId, @params)
            });

        /// <summary>
        /// Get all by not answered questions
        /// </summary>
        /// <param name="params"></param>
        /// <returns></returns>
        [HttpGet("get-list-not-answered")]
        public async ValueTask<IActionResult> GetAllByNotAnsweredQuestionAsync([FromQuery] PaginationParams @params)
            => Ok(new Response
            {
                Code = 200,
                Message = "Success",
                Data = await this.questionService.RetrieveAllNotAnsweredQuestionsAsync(@params)
            });
    }
}
