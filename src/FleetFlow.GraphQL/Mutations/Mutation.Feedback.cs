using FleetFlow.GraphQL.Extensions;
using FleetFlow.Service.DTOs.Attachments;
using FleetFlow.Service.DTOs.Feedbacks;
using FleetFlow.Service.Interfaces.Orders;


namespace FleetFlow.GraphQL.Mutations;
public partial class Mutation
{
    public async ValueTask<FeedbackResultDto> CreateFeedbackAsync([Service] IFeedbackService feedbackService,
            FeedbackCreationDto feedback, List<IFile> files)
    {
        var attachments = new List<AttachmentCreationDto>();
        foreach (var file in files)
        {
            attachments.Add(await file.ToAttachmentAsync());
        }

        return await feedbackService.AddAsync(feedback, attachments);
    }

    public async ValueTask<bool> DeleteFeedbackAsync([Service] IFeedbackService feedbackService,
            long id)
    {
        return await feedbackService.DeleteAsync(id);
    }

    public async ValueTask<bool> MarkAsReadAsync([Service] IFeedbackService feedbackService,
        long id)
    {
        return await feedbackService.MarkAsReadAsync(id);
    }




}
