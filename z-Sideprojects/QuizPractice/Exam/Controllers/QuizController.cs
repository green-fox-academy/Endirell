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
        [HttpGet("home")]
        public IActionResult Index()
        {
            //QuizRepository.GetViewModel()
            return View();
        }
                
        [HttpGet("home/{score}")]
        public IActionResult Index(int score)
        {
            
            return View();
        }

        //[HttpPost("question")]
        //public IActionResult PostQuestion(Question question)
        //{
        //    quizService.AddQuestion(question);
        //    return Redirect("/home");
        //}
    }
}
