using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.UserQuestions;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Service.DTOs.Questions;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.UserQuestions;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.UserQuestions;

public class AnswerService : IAnswerService
{
    private readonly IMapper mapper;
    private readonly IRepository<User> userRepository;
    private readonly IRepository<Answer> answerRepository;
    private readonly IRepository<Question> questionRepository;

    public AnswerService(
        IRepository<Question> questionRepository,
        IRepository<Answer> answerRepository,
        IMapper mapper)
    {
        this.questionRepository = questionRepository;
        this.answerRepository = answerRepository;
        this.mapper = mapper;
    }

    /// <summary>
    /// Adds new Answer for the given question to database
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    public async Task<Answer> AddAsync(AnswerForCreationDto dto)
    {
        if (dto.AnsweredQuestionId is not null)
        {
            long questionId = (long)dto.AnsweredQuestionId;

            var question = await questionRepository.SelectAsync(q => q.Id == dto.AnsweredQuestionId && !q.IsDeleted);
            if (question is null)
                throw new FleetFlowException(404, "Question is not found");

            question.IsAnswered = true;
        }
        else if ((await this.userRepository.SelectAsync(u => u.Id == dto.AnsweredUserId && !u.IsDeleted)) is null)
            throw new FleetFlowException(404, "User is not found");

        var mappedAnswer = mapper.Map<Answer>(dto);
        mappedAnswer.AdminId = (long)HttpContextHelper.UserId;

        var insertedAnswer = await answerRepository.InsertAsync(mappedAnswer);

        await answerRepository.SaveAsync();

        return mapper.Map<Answer>(insertedAnswer);
    }

    /// <summary>
    /// Deletes Answer by given id from database
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="FleetFlowException"></exception>

    public async Task<bool> RemoveByIdAsync(long id)
    {
        var answer = await answerRepository.SelectAsync(a => a.Id == id && !a.IsDeleted);
        if (answer is null)
            throw new FleetFlowException(404, "Answer is not found");

        answer.DeletedBy = HttpContextHelper.UserId;

        await answerRepository.DeleteAsync(a => a.Id == id);
        await answerRepository.SaveAsync();
        return true;
    }

    /// <summary>
    /// Gets All answers with pagination
    /// </summary>
    /// <param name="params"></param>
    /// <returns></returns>
    public async Task<IEnumerable<Answer>> RetrieveAllAsync(PaginationParams @params)
        => await answerRepository
            .SelectAll(u => !u.IsDeleted)
            .ToPagedList(@params)
            .ToListAsync();

    /// <summary>
    /// Gets All Asnwer with pagination by AdminId
    /// </summary>
    /// <param name="params"></param>
    /// <param name="adminId"></param>
    /// <returns></returns>
    public async Task<IEnumerable<Answer>> RetrieveAllByAdminIdAsync(PaginationParams @params, long adminId)
        => await answerRepository
            .SelectAll(a => a.AdminId == adminId && !a.IsDeleted)
            .ToPagedList(@params)
            .ToListAsync();

    /// <summary>
    /// Gets All Answers with pagination by UserId
    /// </summary>
    /// <param name="params"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    public async Task<IEnumerable<Answer>> RetrieveAllByUserIdAsync(PaginationParams @params, long userId)
        => await answerRepository
            .SelectAll(a => a.AnsweredUserId == userId && !a.IsDeleted)
            .ToPagedList(@params)
            .ToListAsync();

    /// <summary>
    /// Gets Answer by id 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="FleetFlowException"></exception>
    public async Task<Answer> RetrieveByIdAsync(long id)
    {
        var answer = await answerRepository.SelectAsync(a => a.Id == id && !a.IsDeleted);
        if (answer is null)
            throw new FleetFlowException(404, "Answer is not found");

        return answer;
    }

    /// <summary>
    /// Updates answer by id 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="dto"></param>
    /// <returns></returns>
    /// <exception cref="FleetFlowException"></exception>
    public async Task<Answer> ModifyByIdAsync(long id, string message)
    {
        var answer = await answerRepository.SelectAsync(a => a.Id == id && !a.IsDeleted);
        if (answer is null)
            throw new FleetFlowException(404, "Couldn't found answer for given Id");

        answer.UpdatedAt = DateTime.UtcNow;
        answer.Message = message;
        answer.UpdatedBy = HttpContextHelper.UserId;

        await answerRepository.SaveAsync();

        return answer;
    }
}