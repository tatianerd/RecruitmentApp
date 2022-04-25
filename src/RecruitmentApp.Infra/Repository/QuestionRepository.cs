using Dapper;
using RecruitmentApp.Domain.Repository;
using RecruitmentApp.Infra.Context;
using RecruitmentApp.Infra.DTO;
using System.Collections.Generic;
using AutoMapper;
using RecruitmentApp.Domain.Model;
using System.Threading.Tasks;

namespace RecruitmentApp.Infra.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly DbContext _dbContext;
        private readonly IMapper _mapper;

        public QuestionRepository(DbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Question>> ListAllQuestionsAsync()
        {
            var query = "select * from Questions";

            var result = await _dbContext.Connection.QueryAsync<QuestionDTO>(query, null, _dbContext.Transaction).ConfigureAwait(false);

            return _mapper.Map<IEnumerable<QuestionDTO>, IEnumerable<Question>>(result);
        }
    }
}
