using RecruitmentApp.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecruitmentApp.Application.Services
{
    public interface IQuestionService
    {
        Task<IEnumerable<Question>> ListAllQuestionsAsync();
    }
}
