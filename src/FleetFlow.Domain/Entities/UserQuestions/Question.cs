using FleetFlow.Domain.Commons;

namespace FleetFlow.Domain.Entities.UserQuestions;

public class Question : Auditable
{
    public string Message { get; set; }
    public long UserId { get; set; }
    public bool IsAnswered { get; set; }
}
