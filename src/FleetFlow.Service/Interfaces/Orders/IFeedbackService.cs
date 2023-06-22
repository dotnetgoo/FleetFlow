using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Attachments;
using FleetFlow.Service.DTOs.Feedbacks;

namespace FleetFlow.Service.Interfaces.Orders;

public interface IFeedbackService
{
    Task<FeedbackResultDto> AddAsync(FeedbackCreationDto dto, List<AttachmentCreationDto> attachments);
    Task<bool> DeleteAsync(long id);
    Task<FeedbackResultDto> RetrieveAsync(long id);

    // for admins
    Task<IEnumerable<FeedbackResultDto>> RetriveAllByClientIdAsync(long clientId);
    Task<IEnumerable<FeedbackResultDto>> RetriveAllByStatusAsync(PaginationParams @params,
        FeedbackStatus? status = null);
    Task<bool> MarkAsReadAsync(long id);
}
