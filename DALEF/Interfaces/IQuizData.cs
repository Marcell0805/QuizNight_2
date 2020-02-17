using System;
using System.Collections.Generic;
using System.Text;
using Quiz.Core;

namespace Quiz.Data
{
    public interface IQuizData
    {
        IEnumerable<QuizClass> GetAll();
        IEnumerable<QuizClass> FetchByCatId(int CatId);
    }
}
