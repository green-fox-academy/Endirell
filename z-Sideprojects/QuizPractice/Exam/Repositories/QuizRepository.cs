using Quiz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quiz.Models;

namespace Quiz.Repositories
{
    public class QuizRepository
    {
        private QuizContext QuizContext;

        public QuizRepository(QuizContext QuizContext)
        {
            this.QuizContext = QuizContext;
        }
    }
}
