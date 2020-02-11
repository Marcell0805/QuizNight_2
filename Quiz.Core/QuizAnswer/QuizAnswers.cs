using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Core
{
    public class QuizAnswers
    {
        public int QuizAnsId { get; set; }
        public int QuestionId { get; set; }
        public string Ans1 { get; set; }
        public string Ans2 { get; set; }
        public string Ans3 { get; set; }
        public string Ans4 { get; set; }

        public int CorrectAns { get; set; }

    }
}
