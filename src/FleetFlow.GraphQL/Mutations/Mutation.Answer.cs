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
            return await answerService.RemoveByIdAsync(id);
        }

        public async ValueTask<Answer> UpdateAddressAsync([Service] IAnswerService answerService,
            long id,
            string message)
        {
            return await answerService.ModifyByIdAsync(id, message);
        }

        public async ValueTask<Answer> GetAnswerByIdAsync([Service] IAnswerService answerService,
            long id)
        {
            return await answerService.RetrieveByIdAsync(id);
        }
    }
}
