using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Entities.Users;

namespace FleetFlow.Domain.Entities.UserQuestions;

public class Answer : Auditable
{
    public string Message { get; set; }
    public long AdminId { get; set; }
    public User Admin { get; set; }
    public long AnsweredUserId { get; set; }
    public User AnsweredUser { get; set; }
    public long? AnsweredQuestionId { get; set; }
    public Question AnsweredQuestion { get; set; }
}