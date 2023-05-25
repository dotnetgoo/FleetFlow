using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.UserQuestions;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.DTOs.Questions;
using FleetFlow.Service.DTOs.User;

namespace FleetFlow.Service.Interfaces.UserQuestions;

public interface IAnswerService
{
    Task<Answer> AddAsync(AnswerForCreationDto dto);
    Task<bool> DeleteByIdAsync(long id);
    Task<Answer> UpdateByIdAsync(long id, AnswerForCreationDto dto);
    Task<Answer> GetByIdAsync(long id);
    Task<IEnumerable<Answer>> GetAllAsync(PaginationParams @params);
    Task<IEnumerable<Answer>> GetAllByUserIdAsync(PaginationParams @params, long userId);
    Task<IEnumerable<Answer>> GetAllByAdminIdAsync(PaginationParams @params, long adminId);
}
