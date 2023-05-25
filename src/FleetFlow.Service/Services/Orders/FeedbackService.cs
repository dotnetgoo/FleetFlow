using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Feedbacks;
using FleetFlow.Service.Interfaces.Orders;

namespace FleetFlow.Service.Services.Orders;

public class FeedbackService : IFeedbackService
{
    public Task<FeedbackResultDto> AddAsync(FeedbackCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task MarkAsReadAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<FeedbackResultDto> RetrieveAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<FeedbackResultDto>> RetriveAllByClientIdAsync(long clientId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<FeedbackResultDto>> RetriveAllByStatusAsync(PaginationParams @params, FeedbackStatus? status = null)
    {
        throw new NotImplementedException();
    }

    public Task<FeedbackResultDto> UpdateAsync(FeedbackUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
