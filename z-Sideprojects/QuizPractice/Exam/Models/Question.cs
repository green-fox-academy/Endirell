using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public class Question
    {
        public long Id { get; set; }
        public string AskQuestion { get; set; }
        public string AnswerOne { get; set; }
        public string AnswerTwo { get; set; }
        public string AnswerThree { get; set; }
        public string AnswerFour { get; set; }
        public string TrueAnswer { get; set; }
    }
}
