using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.UserQuestions;
using FleetFlow.Service.DTOs.Questions;

namespace FleetFlow.Service.Interfaces.UserQuestions;

public interface IQuestionService
{
    Task<bool> RemoveAsync(long id);
    Task<QuestionForResultDto> RetrieveByIdAsync(long id);
    Task<QuestionForResultDto> AddAsync(QuestionForCreationDto dto);
    Task<QuestionForResultDto> ModifyAsync(long id, QuestionForCreationDto dto);
    Task<IEnumerable<QuestionForResultDto>> RetrieveAllAsync(PaginationParams @params);
    Task<IEnumerable<QuestionForResultDto>> RetrieveAllNotAnsweredQuestionsAsync(PaginationParams @params);
    Task<IEnumerable<QuestionForResultDto>> RetrieveAllByUserIdAsync(long userId, PaginationParams @params);
}
