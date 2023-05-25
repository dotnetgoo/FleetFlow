namespace FleetFlow.Service.DTOs.Questions;

public class AnswerForCreationDto
{
    public string Message { get; set; }
    public long AnsweredUserId { get; set; }
    public long? AnsweredQuestionId { get; set; }
}
