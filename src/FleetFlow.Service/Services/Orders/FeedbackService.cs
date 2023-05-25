using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Attachments;
using FleetFlow.Domain.Entities.Orders;
using FleetFlow.Domain.Entities.Orders.Feedbacks;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Carts;
using FleetFlow.Service.DTOs.Feedbacks;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.Attachments;
using FleetFlow.Service.Interfaces.Orders;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.Orders;

public class FeedbackService : IFeedbackService
{
    private readonly IMapper mapper;
    private readonly IRepository<Feedback> feedbackRepository;
    private readonly IRepository<Order> orderRepository; 
    private readonly IAttachmentService attachmentService;
    private readonly IRepository<FeedbackAttachment> feedbackAttachmentRepository;
    public FeedbackService(IMapper mapper,
        IRepository<Feedback> feedbackRepository,
        IRepository<FeedbackAttachment> feedbackAttachmentRepository,
        IRepository<Order> orderRepository,
        IAttachmentService attachmentService)
    {
        this.feedbackAttachmentRepository = feedbackAttachmentRepository;
        this.feedbackRepository = feedbackRepository;
        this.mapper = mapper;
        this.orderRepository = orderRepository;        
        this.attachmentService = attachmentService;
    }

    public async Task<FeedbackResultDto> AddAsync(FeedbackCreationDto dto)
    {
        var order = await orderRepository.SelectAsync(o => o.Id == dto.OrderId && !o.IsDeleted);
        if(order is null)
            throw new FleetFlowException(404, "Order not found");
        
        var feedback = mapper.Map<Feedback>(dto);
        var insertedFeedback = await feedbackRepository.InsertAsync(feedback);

        if (dto.Attachments is not null && dto.Attachments.Any())
        {
            foreach (var attachment in dto.Attachments)
            {
                var insertedAttachment = await attachmentService.UploadAsync(attachment);
                await feedbackAttachmentRepository.InsertAsync(new FeedbackAttachment
                {
                    AttachmentId = insertedAttachment.Id,
                    FeedbackId = insertedAttachment.Id
                });
            }
        }

        await feedbackRepository.SaveAsync();
        
        return mapper.Map<FeedbackResultDto>(insertedFeedback); ;
    }

    public async Task<bool> DeleteAsync(long id)
    {
        Feedback feedback = await feedbackRepository.SelectAsync(f => f.Id == id && !f.IsDeleted, new string[] { "Attachments" });
        if (feedback is null)
            throw new FleetFlowException(404, "Feedback not found");

        // removing attachments
        foreach (var attachment in feedback.Attachments)
        {
            await attachmentService.DeleteAsync(attachment.Id);
            await feedbackAttachmentRepository.DeleteAsync(fa => fa.Id == attachment.Id);
            await feedbackAttachmentRepository.SaveAsync();

        }

        var isDeleted = await feedbackRepository.DeleteAsync(f => f.Id == id);
        await this.feedbackRepository.SaveAsync();
        
        return isDeleted;
    }

    public async Task<bool> MarkAsReadAsync(long id)
    {
        var feedback = await this.feedbackRepository.SelectAsync(f => !f.IsDeleted && f.Id == id);
        if (feedback is null)
            throw new FleetFlowException(404, "Feedback not found");

        feedback.Status = FeedbackStatus.Seen;
        await this.feedbackRepository.SaveAsync();

        return true;
    }

    public async Task<FeedbackResultDto> RetrieveAsync(long id)
    {
        Feedback feedback = await this.feedbackRepository.SelectAsync(f => !f.IsDeleted && f.Id == id, new string[] { "Attachments.Attachment" });
        if (feedback is null)
            throw new FleetFlowException(404, "Feedback not found");

        return this.mapper.Map<FeedbackResultDto>(feedback);
    }

    public async Task<IEnumerable<FeedbackResultDto>> RetriveAllByClientIdAsync(long clientId)
    {
        var feedbacks = await this.feedbackRepository.SelectAll(f => !f.IsDeleted && f.Order.User.Id == clientId).ToListAsync();
        if (feedbacks is null || !feedbacks.Any())
            throw new FleetFlowException(404, "Feedback not found");

        return this.mapper.Map<IEnumerable<FeedbackResultDto>>(feedbacks);
    }

    public async Task<IEnumerable<FeedbackResultDto>> RetriveAllByStatusAsync(PaginationParams @params, FeedbackStatus? status = null)
    {
        var feedbacksQuery = this.feedbackRepository.SelectAll(f => !f.IsDeleted);
        if (status is not null)
            feedbacksQuery = feedbacksQuery.Where(f => f.Status == status);

        feedbacksQuery = feedbacksQuery.ToPagedList(@params);

        var feedbacks = await feedbacksQuery.ToListAsync();
        if (feedbacks is null || !feedbacks.Any())
            throw new FleetFlowException(404, "Feedback not found");

        return this.mapper.Map<IEnumerable<FeedbackResultDto>>(feedbacks);
    }
}