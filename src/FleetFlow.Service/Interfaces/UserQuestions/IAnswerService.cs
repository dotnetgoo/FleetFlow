using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.UserQuestions;
using FleetFlow.Service.DTOs.Questions;

namespace FleetFlow.Service.Interfaces.UserQuestions;

public interface IAnswerService
{
    Task<Answer> AddAsync(AnswerForCreationDto dto);
    Task<bool> DeleteByIdAsync(long id);
    Task<Answer> UpdateByIdAsync(long id, AnswerForCreationDto dto);
    Task<Answer> GetByIdAsync(long id);
    Task<IEnumerable<Answer>> GetAllAsync(PaginationParams @params);
    Task<IEnumerable<Answer>> GetAllByUserIdAsync(long userId);
    Task<IEnumerable<Answer>> GetAllByAdminIdAsync(long adminId);
}
