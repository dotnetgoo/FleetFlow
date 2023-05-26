using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Entities.UserQuestions;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Service.DTOs.Questions;
using FleetFlow.Service.DTOs.User;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.UserQuestions;
using FleetFlow.Shared.Helpers;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace FleetFlow.Service.Services.UserQuestions;

public class AnswerService : IAnswerService
{
    private readonly IRepository<Answer> answerRepository;
    private readonly IRepository<Question> questionRepository;
    private readonly IQuestionService questionService;
    private readonly IMapper mapper;

    public AnswerService(
        IRepository<Answer> answerRepository,
        IRepository<Question> questionRepository,
        IQuestionService questionService,
        IMapper mapper)
    {
        this.answerRepository = answerRepository;
        this.questionRepository = questionRepository;
        this.questionService = questionService;
        this.mapper = mapper;
    }

    /// <summary>
    /// Adds new Answer for the given question to database
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    public async Task<Answer> AddAsync(long questionId, AnswerForCreationDto dto)
    {
        var question = await questionService.GetByIdAsync(questionId);
        if (question is null)
            throw new FleetFlowException(404, "Question Not Found");

        var mapped = mapper.Map<Answer>(dto);

        mapped.QuestionId = questionId;

        var insertedAnswer = await answerRepository.InsertAsync(mapped);

        await answerRepository.SaveAsync();

        return mapper.Map<Answer>(insertedAnswer);
    }

    /// <summary>
    /// Deletes Answer by given id from database
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="FleetFlowException"></exception>

    public async Task<bool> DeleteByIdAsync(long id)
    {
        var answer = await answerRepository.SelectAsync(a => a.Id == id);
        if (answer is null)
            throw new FleetFlowException(404, "Couldn't find answer for this given Id");

        var accessor = HttpContextHelper.Accessor;

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
    public async Task<IEnumerable<Answer>> GetAllAsync(PaginationParams @params)
    {
        var answers = await answerRepository.SelectAll()
            .Where(u => u.IsDeleted == false)
            .ToPagedList(@params)
            .ToListAsync();

        return mapper.Map<IEnumerable<Answer>>(answers);
    }

    /// <summary>
    /// Gets All Asnwer with pagination by AdminId
    /// </summary>
    /// <param name="params"></param>
    /// <param name="adminId"></param>
    /// <returns></returns>
    public async Task<IEnumerable<Answer>> GetAllByAdminIdAsync(PaginationParams @params, long adminId)
    {
        var adminsAnswer = await answerRepository.SelectAll()
            .Where(a => a.AdminId == adminId)
            .ToPagedList(@params)
            .ToListAsync();

        return mapper.Map<IEnumerable<Answer>>(adminsAnswer);
    }

    /// <summary>
    /// Gets All Answers with pagination by UserId
    /// </summary>
    /// <param name="params"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    public async Task<IEnumerable<Answer>> GetAllByUserIdAsync(PaginationParams @params, long userId)
    {
        var userAnswers = await answerRepository.SelectAll()
            .Where(a => a.UserId == userId)
            .ToPagedList(@params)
            .ToListAsync();

        return mapper.Map<IEnumerable<Answer>>(userAnswers);
    }

    /// <summary>
    /// Gets Answer by id 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="FleetFlowException"></exception>
    public async Task<Answer> GetByIdAsync(long id)
    {
        var answer = await answerRepository.SelectAsync(a => a.Id == id);
        if (answer is null)
            throw new FleetFlowException(404, "Answer Not Found");

        return mapper.Map<Answer>(answer);
    }

    /// <summary>
    /// Updates answer by id 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="dto"></param>
    /// <returns></returns>
    /// <exception cref="FleetFlowException"></exception>
    public async Task<Answer> UpdateByIdAsync(long id, AnswerForCreationDto dto)
    {
        var answer = await answerRepository.SelectAsync(a => a.Id == id);
        if (answer is null)
            throw new FleetFlowException(404, "Couldn't found answer for given Id");

        var updatedAsnwer = mapper.Map(dto, answer);
        updatedAsnwer.UpdatedAt = DateTime.UtcNow;
        updatedAsnwer.UpdatedBy = HttpContextHelper.UserId;

        await answerRepository.SaveAsync();

        return mapper.Map<Answer>(answer);
    }
}