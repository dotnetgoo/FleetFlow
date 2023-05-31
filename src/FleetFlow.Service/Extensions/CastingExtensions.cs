using FleetFlow.Domain.Entities.Orders.Feedbacks;
using FleetFlow.Service.DTOs.Attachments;
using FleetFlow.Service.DTOs.Feedbacks;

namespace FleetFlow.Service.Extensions
{
    public static class CastingExtensions
    {
        public static FeedbackResultDto ToFeedbackResultDto(this Feedback feedback)
        {
            var result = new FeedbackResultDto();
            result.Id = feedback.Id;
            result.Message = feedback.Message;
            result.Status = feedback.Status;
            result.OrderId = feedback.OrderId;
            if (feedback.Attachments is not null && feedback.Attachments.Any())
            {
                result.Attachments = new List<AttachmentResultDto>();

                foreach (var attachment in feedback.Attachments)
                {
                    var attachmentDto = new AttachmentResultDto
                    {
                        Id = attachment.Attachment.Id,
                        FileName = attachment.Attachment.FileName
                    };
                    result.Attachments.Add(attachmentDto);
                }
            }
            return result;
        }
    }
}
