using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.UserQuestions;
using FleetFlow.Service.Interfaces.UserQuestions;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<Answer> GetAnswerByIdAsync([Service] IAnswerService answerService,
            long id)
        {
            return await answerService.RetrieveByIdAsync(id);
        }

        public async ValueTask<IEnumerable<Answer>> GetAllAnswersAsync([Service] IAnswerService answerService,
            PaginationParams @params)
        {
            return await answerService.RetrieveAllAsync(@params);
        }

        public async ValueTask<IEnumerable<Answer>> GetAllAnswersByUserIdAsync([Service] IAnswerService answerService,
            PaginationParams @params,
            long userId)
        {
            return await answerService.RetrieveAllByUserIdAsync(@params, userId);
        }

        public async ValueTask<IEnumerable<Answer>> GetAllAnswersByAdminIdAsync([Service] IAnswerService answerService,
            PaginationParams @params,
            long adminId)
        {
            return await answerService.RetrieveAllByAdminIdAsync(@params, adminId);
        }
    }
}