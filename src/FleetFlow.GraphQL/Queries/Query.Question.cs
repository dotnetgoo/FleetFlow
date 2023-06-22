using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.UserQuestions;
using FleetFlow.Service.Interfaces.UserQuestions;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<Question> GetQuestionAsync([Service] IQuestionService questionService,
            long id)
        {
            return await questionService.RetrieveByIdAsync(id);
        }

        public async ValueTask<IEnumerable<Question>> GetAllQuestionsAsync([Service] IQuestionService questionService,
            PaginationParams @params)
        {
            return await questionService.RetrieveAllAsync(@params);
        }

        public async ValueTask<IEnumerable<Question>> GetAllQuestionsByUserIdAsync([Service] IQuestionService questionService,
            long userId,
            PaginationParams @params)
        {
            return await questionService.RetrieveAllByUserIdAsync(userId, @params);
        }

        public async ValueTask<IEnumerable<Question>> GetAllNotAnsweredQuestionsAsync([Service] IQuestionService questionService,
            PaginationParams @params)
        {
            return await questionService.RetrieveAllNotAnsweredQuestionsAsync(@params);
        }
    }
}
