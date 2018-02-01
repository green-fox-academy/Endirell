using Quiz.Models;
using System.Collections.Generic;

namespace Quiz.ViewModels
{
    public class QuizViewModel
    {
        public int Score { get; set; }
        public List<Question> Questions { get; set; }       

    }
}
