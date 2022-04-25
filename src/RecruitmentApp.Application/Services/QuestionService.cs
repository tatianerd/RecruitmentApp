using RecruitmentApp.Domain.Model;
using RecruitmentApp.Domain.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecruitmentApp.Application.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionService(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public async Task<IEnumerable<Question>> ListAllQuestionsAsync()
        {
            return await _questionRepository.ListAllQuestionsAsync().ConfigureAwait(false);
        }
    }
}
