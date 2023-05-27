using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.UserQuestions;
using FleetFlow.Service.DTOs.Questions;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.UserQuestions;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.Questions
{
    public class QuestionService : IQuestionService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Question> questionRepository;

        public QuestionService(IMapper mapper, IRepository<Question> questionRepository)
        {
            this.mapper = mapper;
            this.questionRepository = questionRepository;
        }
        public async Task<Question> AddAsync(QuestionForCreationDto dto)
        {
            var mappedQuestion = mapper.Map<Question>(dto);
            mappedQuestion.UserId = (long)HttpContextHelper.UserId;

            var createdQuestion = await questionRepository.InsertAsync(mappedQuestion);
            await questionRepository.SaveAsync();

            return createdQuestion;
        }

        public async Task<bool> RemoveAsync(long id)
        {
            var question = await questionRepository.SelectAsync(q => q.Id == id && !q.IsDeleted);
            if (question is null)
                throw new FleetFlowException(404, "Question is not found!");

            question.DeletedBy = HttpContextHelper.UserId;
            await questionRepository.DeleteAsync(q => q.Id == id);
            await questionRepository.SaveAsync();

            return true;
        }

        public async Task<Question> RetrieveByIdAsync(long id)
        {
            var question = await questionRepository.SelectAsync(q => q.Id == id && !q.IsDeleted);
            if (question is null)
                throw new FleetFlowException(404, "Question is not found");

            return question;
        }


        public async Task<Question> ModifyAsync(long id, string message)
        {
            var question = await questionRepository.SelectAsync(q => q.Id == id && !q.IsDeleted);
            if (question is null)
                throw new FleetFlowException(404, "Question is not found");

            question.UpdatedAt = DateTime.UtcNow;
            question.UpdatedBy = HttpContextHelper.UserId;

            await questionRepository.SaveAsync();

            return question;
        }

        public async Task<IEnumerable<Question>> RetrieveAllAsync(PaginationParams @params)
            => await questionRepository.SelectAll(q => !q.IsDeleted)
                .ToPagedList(@params)
                .ToListAsync();

        public async Task<IEnumerable<Question>> RetrieveAllNotAnsweredQuestionsAsync(PaginationParams @params)
            => await questionRepository.SelectAll(q => !q.IsAnswered && !q.IsDeleted)
                .ToPagedList(@params)
                .ToListAsync();

        public async Task<IEnumerable<Question>> RetrieveAllByUserIdAsync(long userId, PaginationParams @params)
            => await questionRepository.SelectAll(q => q.UserId == userId && !q.IsDeleted)
                .ToPagedList(@params)
                .ToListAsync();
    }
}
