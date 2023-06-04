using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.UserQuestions;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.DTOs.Questions;
using FleetFlow.Service.DTOs.User;

namespace FleetFlow.Service.Interfaces.UserQuestions;

public interface IAnswerService
{
    Task<bool> RemoveByIdAsync(long id);
    Task<Answer> RetrieveByIdAsync(long id);
    Task<Answer> AddAsync(AnswerForCreationDto dto);
    Task<Answer> ModifyByIdAsync(long id, string message);
    Task<IEnumerable<Answer>> RetrieveAllAsync(PaginationParams @params = null);
    Task<IEnumerable<Answer>> RetrieveAllByUserIdAsync(long userId, PaginationParams @params = null);
    Task<IEnumerable<Answer>> RetrieveAllByAdminIdAsync(long adminId, PaginationParams @params = null);
}
