using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Entities.Users;

namespace FleetFlow.Domain.Entities.UserQuestions;

public class Question : Auditable
{
    public string Message { get; set; }
    public bool IsAnswered { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
}
