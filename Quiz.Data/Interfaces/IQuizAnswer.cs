using System.Collections.Generic;
using Quiz.Core;

namespace Quiz.Data
{
    public interface IQuizAnswer
    {
        IEnumerable<QuizAnswers> GetAll();
        IEnumerable<QuizAnswers> FetchById(int QuestionId);

        int GetCount(int StartQ,int EndQ);
    }
}