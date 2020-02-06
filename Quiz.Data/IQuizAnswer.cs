using System.Collections.Generic;
using System.Linq;
using Quiz.Core;

namespace Quiz.Data
{
    public interface IQuizAnswer
    {
        IEnumerable<QuizAnswers> GetAll();
        IEnumerable<QuizAnswers> FetchById(int QuestionId);

        int GetCount(int StartQ,int EndQ);
    }

    public class InMemoryAnswers : IQuizAnswer
    {
        public List<QuizAnswers> QuizAnswerses;
        public InMemoryAnswers()
        {
            QuizAnswerses= new List<QuizAnswers>()
            {
                 new QuizAnswers{QuestionId = 1,QuizAnsId = 1,Ans1 = "Jeff",Ans2 = "Altair",Ans3 = "Etzio",Ans4 = "Susan",CorrectAns = 2},
                 new QuizAnswers{QuestionId = 2,QuizAnsId = 2,Ans1 = "Doom Slayer",Ans2 = "Doom Guy",Ans3 = "Doom Doom",Ans4 = "Dom",CorrectAns = 1},
                 new QuizAnswers{QuestionId = 3,QuizAnsId = 3,Ans1 = "Olaf",Ans2 = "Frosty",Ans3 = "Icy",Ans4 = "Snowy",CorrectAns = 1},
                 new QuizAnswers{QuestionId = 4,QuizAnsId = 4,Ans1 = "2077",Ans2 = "2030",Ans3 = "2022",Ans4 = "2020",CorrectAns = 4},
                 new QuizAnswers{QuestionId = 5,QuizAnsId = 5,Ans1 = "Geralt",Ans2 = "Ciri",Ans3 = "Roach",Ans4 = "Dandelion",CorrectAns = 1},

                 new QuizAnswers{QuestionId = 6,QuizAnsId = 6,Ans1 = "Jeremy Loops",Ans2 = "Johnny Cash",Ans3 = "Brain Johnson",Ans4 = "Nickelback",CorrectAns = 3},
                 new QuizAnswers{QuestionId = 7,QuizAnsId = 7,Ans1 = "Connor Youngblood",Ans2 = "Chester Charles Bennington",Ans3 = "Amy Lee",Ans4 = "Fred Durst",CorrectAns = 2},
                 new QuizAnswers{QuestionId = 8,QuizAnsId = 8,Ans1 = "Queen",Ans2 = "The Beetles",Ans3 = "Beegees",Ans4 = "Papa Roach",CorrectAns = 1},
                 new QuizAnswers{QuestionId = 9,QuizAnsId = 9,Ans1 = "Linkin Park",Ans2 = "Too close to touch",Ans3 = "Unlike Pluto",Ans4 = "The Beetles",CorrectAns = 4},
                 new QuizAnswers{QuestionId = 10,QuizAnsId = 10,Ans1 = "Extra drum music",Ans2 = "Electic disco music",Ans3 = "Electro dance music",Ans4 = "Electro dance mix",CorrectAns = 2}
            };
        }
        public IEnumerable<QuizAnswers> GetAll()
        {
            return from r in QuizAnswerses
                orderby r.QuestionId
                select r;

        }
        public IEnumerable<QuizAnswers> FetchById(int QuestionId)
        {
            return from r in QuizAnswerses
                   where r.QuizAnsId== QuestionId
                   select r;

        }
        public int GetCount(int StartQ, int EndQ)
        {
            return (from r in QuizAnswerses
                    where r.QuizAnsId>= StartQ && r.QuizAnsId <= EndQ
                    orderby r.QuestionId
                    select r).Count();
        }
    }
}