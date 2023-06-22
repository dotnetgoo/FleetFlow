using FleetFlow.Domain.Entities.UserQuestions;
using FleetFlow.Service.DTOs.Questions;
using FleetFlow.Service.Interfaces.UserQuestions;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        /// <summary>
        /// Add Question 
        /// </summary>
        /// <param name="questionService"></param>
        /// <param name="question"></param>
        /// <returns></returns>
        public async ValueTask<Question> AddQuestionAsync([Service] IQuestionService questionService,
            QuestionForCreationDto question)
        {
            return await questionService.AddAsync(question);
        }

        /// <summary>
        /// Remove Question 
        /// </summary>
        /// <param name="questionService"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public async ValueTask<bool> RemoveQuestionAsync([Service] IQuestionService questionService,
            long id)
        {
            return await questionService.RemoveAsync(id);
        }

        /// <summary>
        /// Update Question
        /// </summary>
        /// <param name="questionService"></param>
        /// <param name="id"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public async ValueTask<Question> UpdateQuestionAsync([Service] IQuestionService questionService,
            long id,
            string message)
        {
            return await questionService.ModifyAsync(id, message);
        }
    }
}
