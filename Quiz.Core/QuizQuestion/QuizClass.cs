using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
namespace Quiz.Core
{
    public partial class QuizClass 
    {
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public int QuestionAnswer { get; set; }
        public int CatId { get; set; }
    }
}
