using RecruitmentApp.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecruitmentApp.Domain.Repository
{
    public interface IQuestionRepository
    {
        Task<IEnumerable<Question>> ListAllQuestionsAsync();
    }
}
