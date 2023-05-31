using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.UserQuestions;
using FleetFlow.Service.DTOs.Questions;

namespace FleetFlow.Service.Interfaces.UserQuestions;

public interface IQuestionService
{
    Task<bool> RemoveAsync(long id);
    Task<Question> RetrieveByIdAsync(long id);
    Task<Question> AddAsync(QuestionForCreationDto dto);
    Task<Question> ModifyAsync(long id, string message);
    Task<IEnumerable<Question>> RetrieveAllAsync(PaginationParams @params);
    Task<IEnumerable<Question>> RetrieveAllNotAnsweredQuestionsAsync(PaginationParams @params);
    Task<IEnumerable<Question>> RetrieveAllByUserIdAsync(long userId, PaginationParams @params);
}
