using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Core
{
    public class QuizClass
    {
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public int QuestionAnswer { get; set; }
        public int CatId { get; set; }
        public DefaultQuizes quizes{get;set;}
    }
}
