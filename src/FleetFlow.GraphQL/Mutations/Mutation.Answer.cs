using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.UserQuestions;
using FleetFlow.Service.DTOs.Questions;
using FleetFlow.Service.Interfaces.UserQuestions;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<Answer> CreateAddressAsync([Service] IAnswerService answerService,
            AnswerForCreationDto answer)
        {
            return await answerService.AddAsync(answer);
        }

        public async ValueTask<bool> DeleteAsnwerAsync([Service] IAnswerService answerService,
            long id)
        {
            return await answerService.DeleteByIdAsync(id);
        }

        public async ValueTask<Answer> UpdateAddressAsync([Service] IAnswerService answerService,
            long id,
            AnswerForCreationDto answer)
        {
            return await answerService.UpdateByIdAsync(id, answer);
        }

        public async ValueTask<Answer> GetAnswerByIdAsync([Service] IAnswerService answerService,
            long id)
        {
            return await answerService.GetByIdAsync(id);
        }
    }
}
