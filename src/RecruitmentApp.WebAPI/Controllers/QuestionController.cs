using Microsoft.AspNetCore.Mvc;
using RecruitmentApp.Application.Services;
using System.Threading.Tasks;

namespace RecruitmentApp.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("questions")]
    [ApiVersion("1.0")]
    public class QuestionController : Controller
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        /// <summary>
        /// Returns all questions from the database
        /// </summary>
        /// <returns><see cref="Question"/></returns>
        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> ListAllQuestionsAsync()
        {
            var result = await _questionService.ListAllQuestionsAsync().ConfigureAwait(false);

            return Ok(result);
        }

    }
}
