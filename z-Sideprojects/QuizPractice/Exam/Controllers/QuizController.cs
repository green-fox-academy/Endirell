using Microsoft.AspNetCore.Mvc;
using Quiz.Repositories;

namespace Quiz.Controllers
{
    [Route("")]
    public class QuizController : Controller
    {
        private QuizRepository QuizRepository;

        public QuizController(QuizRepository QuizRepository)
        {
            this.QuizRepository = QuizRepository;
        }
        
        [HttpGet("")]
        public IActionResult Index()
        {

            return View();
        }
    }
}
