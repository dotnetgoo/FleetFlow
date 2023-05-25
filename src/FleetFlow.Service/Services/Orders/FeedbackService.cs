using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Orders.Feedbacks;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Feedbacks;
using FleetFlow.Service.Interfaces.Orders;

namespace FleetFlow.Service.Services.Orders;

public class FeedbackService : IFeedbackService
{
    private readonly IMapper mapper;
    private readonly IRepository<Feedback> feedbackRepository;
    private readonly IRepository<FeedbackAttachment> feedbackAttachmentRepository;
    public FeedbackService(IMapper mapper,
        IRepository<Feedback> feedbackRepository,
        IRepository<FeedbackAttachment> feedbackAttachmentRepository)
    {
        this.feedbackAttachmentRepository = feedbackAttachmentRepository;
        this.feedbackRepository = feedbackRepository;
        this.mapper = mapper;
    }

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
