using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.UserQuestions;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.DTOs.Questions;

namespace FleetFlow.Service.Interfaces.UserQuestions;

public interface IQuestionService
{
    Task<Question> AddAsync(QuestionForCreationDto dto);
    Task<bool> DeleteByIdAsync(long id);
    Task<Question> UpdateByIdAsync(long id, QuestionForCreationDto dto);
    Task<Question> GetByIdAsync(long id);
    Task<IEnumerable<Question>> GetAllAsync(PaginationParams @params);
    Task<IEnumerable<Question>> GetAllByUserIdAsync(long userId);
    Task<IEnumerable<Question>> GetAllNotAnsweredQuestionsAsync();
}
