using Microsoft.AspNetCore.Mvc;
using Quiz.Repositories;
using Quiz.Models;

namespace Quiz.Controllers
{
    [Route("")]
    public class QuizController : Controller
    {
        private QuizRepository quizRepository;

        public QuizController(QuizRepository quizRepository)
        {
            this.quizRepository = quizRepository;
        }
        
        [HttpGet("")]
        [HttpGet("home")]
        public IActionResult Index()
        {
            return View(quizRepository.GetViewModel());
        }
                
        [HttpGet("home/{score}")]
        public IActionResult Score(int score)
        {
            return View(score);
        }

        [HttpGet("question")]
        public IActionResult Question()
        {
            return View();
        }

        [HttpPost("question")]
        public IActionResult AddQuestion(Question question)
        {
            quizRepository.AddQuestion(question);            
            return Redirect("/home");
        }

        [HttpGet("quiz")]
        public IActionResult Quiz()
        {
            return View(quizRepository.GetQuestion());
        }

    }
}
