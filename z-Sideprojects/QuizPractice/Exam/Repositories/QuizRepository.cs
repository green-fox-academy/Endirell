using Quiz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quiz.Models;
using Quiz.ViewModels;

namespace Quiz.Repositories
{
    public class QuizRepository
    {
        public static int scorestatic = 2;

        private QuizContext quizContext;

        public QuizRepository(QuizContext quizContext)
        {
            this.quizContext = quizContext;
        }

        public List<Question> GetAllQuestions()
        {
            return quizContext.Questions.ToList();
        }


        public void AddQuestion(Question question)
        {
            if (question.TrueAnswer.Equals("1"))
            {
                question.TrueAnswer = question.AnswerOne;
            }
            if (question.TrueAnswer.Equals("2"))
            {
                question.TrueAnswer = question.AnswerTwo;
            }
            if (question.TrueAnswer.Equals("3"))
            {
                question.TrueAnswer = question.AnswerThree;
            }
            if (question.TrueAnswer.Equals("4"))
            {
                question.TrueAnswer = question.AnswerFour;
            }
            
            quizContext.Questions.Add(question);
            quizContext.SaveChanges();
        }

        public QuizViewModel GetViewModel()
        {
            QuizViewModel viewmodel = new QuizViewModel();

            viewmodel.Score = scorestatic;

            viewmodel.Questions = GetAllQuestions();

            return viewmodel;
        }

        public Question GetQuestion()
        {
            List<Question> quizlist = GetAllQuestions();
            
            Random rnd = new Random();

            int whichquestion = rnd.Next(0, quizlist.Count);

            return quizlist[whichquestion];
        }

    }
}
