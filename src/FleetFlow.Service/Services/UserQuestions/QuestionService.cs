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

namespace FleetFlow.Service.Services.UserQuestions
{
    public class QuestionService : IQuestionService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Question> questionRepository;

        public QuestionService(IMapper mapper, IRepository<Question> questionRepository)
        {
            this.mapper =  mapper;
            this.questionRepository = questionRepository;
        }
        public async Task<QuestionForResultDto> AddAsync(QuestionForCreationDto dto)
        {
            var mappedQuestion = this.mapper.Map<Question>(dto);

            var createdQuestion = await this.questionRepository.InsertAsync(mappedQuestion);
            createdQuestion.UserId = HttpContextHelper.UserId;

            await questionRepository.SaveAsync();

            return this.mapper.Map<QuestionForResultDto>(createdQuestion);
        }
        
        public async Task<bool> RemoveAsync(long id)
        {
            var checkQuestion = await this.questionRepository.SelectAsync(q => q.Id == id);
            if (checkQuestion is null)
                throw new FleetFlowException(404, "Question is not found!");

            await this.questionRepository.DeleteAsync(q => q.Id == id);
            checkQuestion.DeletedBy = HttpContextHelper.UserId;

            await this.questionRepository.SaveAsync();
            
            return true;
        }

        public async Task<QuestionForResultDto> RetrieveByIdAsync(long id)
        {
            var checkQuestion = await this.questionRepository.SelectAsync(q => q.Id == id);
            if (checkQuestion is null || checkQuestion.IsDeleted)
                throw new FleetFlowException(404, "Question is not found");

           return this.mapper.Map<QuestionForResultDto>(checkQuestion);
        }


        public async Task<QuestionForResultDto> ModifyAsync(long id, QuestionForCreationDto dto)
        {
            var checkQuestion = await this.questionRepository.SelectAsync(q => q.Id == id);
            if (checkQuestion is null || checkQuestion.IsDeleted)
                throw new FleetFlowException(404, "Question is not found");

            var mappedQuestion = mapper.Map(dto, checkQuestion);
            mappedQuestion.UpdatedAt = DateTime.UtcNow;
            mappedQuestion.UpdatedBy = HttpContextHelper.UserId;
            
            await questionRepository.SaveAsync();

            return this.mapper.Map<QuestionForResultDto>(mappedQuestion);
        }

        public async Task<IEnumerable<QuestionForResultDto>> RetrieveAllAsync(PaginationParams @params)
        {
            var questions = await this.questionRepository.SelectAll()
                .Where(q => q.IsDeleted == false)
                .ToPagedList(@params)
                .ToListAsync();


            return this.mapper.Map<IEnumerable<QuestionForResultDto>>(questions);
        }

        public async Task<IEnumerable<QuestionForResultDto>> RetrieveAllNotAnsweredQuestionsAsync(PaginationParams @params)
        {
            var notAnsweredQuestions = await this.questionRepository.SelectAll()
                .Where(q => q.IsAnswered == true && q.IsDeleted == false)
                .ToPagedList(@params)
                .ToListAsync();

            return this.mapper.Map<IEnumerable<QuestionForResultDto>>(notAnsweredQuestions);
        }

        public async Task<IEnumerable<QuestionForResultDto>> RetrieveAllByUserIdAsync(long userId, PaginationParams @params)
        {
            var questions = await this.questionRepository.SelectAll()
                .Where(q => q.UserId == userId && q.IsDeleted == false)
                .ToPagedList(@params)
                .ToListAsync();

            return this.mapper.Map<IEnumerable<QuestionForResultDto>>(questions);
        }
    }
}
