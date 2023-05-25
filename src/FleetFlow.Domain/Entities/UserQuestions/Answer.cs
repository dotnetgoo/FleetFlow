﻿using FleetFlow.Domain.Commons;
using System.Diagnostics.Contracts;

namespace FleetFlow.Domain.Entities.UserQuestions;

public class Answer : Auditable
{
    public string Message { get; set; }
    public long UserId { get; set; }
    public long AdminId { get; set; }
    public long AnsweredUserId { get; set; }
    public long? AnsweredQuestionId { get; set; }
}