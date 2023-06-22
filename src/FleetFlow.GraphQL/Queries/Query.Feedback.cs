using FleetFlow.Domain.Congirations;
using FleetFlow.GraphQL.Extensions;
using FleetFlow.GraphQL.Types.EnumTypes;
using FleetFlow.Service.DTOs.Feedbacks;
using FleetFlow.Service.Interfaces.Orders;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<FeedbackResultDto> GetFeedbackAsync([Service] IFeedbackService feedbackService,
            long id)
        {
            return await feedbackService.RetrieveAsync(id);
        }

        public async ValueTask<IEnumerable<FeedbackResultDto>> GetAllFeedbacksByStatusAsync([Service] IFeedbackService feedbackService,
            PaginationParams @params,
            FeedbackStatusEnumType status = null)
        {
            return await feedbackService.RetriveAllByStatusAsync(@params, status.ToFeedbackStatus());
        }

        public async ValueTask<IEnumerable<FeedbackResultDto>> GetAllFeedbacksByClientIdAsync([Service] IFeedbackService feedbackService,
            long clientId)
        {
            return await feedbackService.RetriveAllByClientIdAsync(clientId);
        }
    }
}
