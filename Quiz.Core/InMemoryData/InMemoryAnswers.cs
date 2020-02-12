using Quiz.Data;
using System.Collections.Generic;
using System.Linq;

namespace Quiz.Core
{
    public class InMemoryAnswers : IRepository<QuizAnswers>
    {
        public List<QuizAnswers> QuizAnswerses;

        

        public InMemoryAnswers()
        {
            QuizAnswerses= new List<QuizAnswers>()
            {
                 new QuizAnswers{QuestionId = 1,Id = 1,Answer1 = "Jeff",Answer2 = "Altair",Answer3 = "Etzio",Answer4 = "Susan",CorrectAns = 2},
                 new QuizAnswers{QuestionId = 2,Id = 2,Answer1 = "Doom Slayer",Answer2 = "Doom Guy",Answer3 = "Doom Doom",Answer4 = "Dom",CorrectAns = 1},
                 new QuizAnswers{QuestionId = 3,Id = 3,Answer1 = "Olaf",Answer2 = "Frosty",Answer3 = "Icy",Answer4 = "Snowy",CorrectAns = 1},
                 new QuizAnswers{QuestionId = 4,Id = 4,Answer1 = "2077",Answer2 = "2030",Answer3 = "2022",Answer4 = "2020",CorrectAns = 4},
                 new QuizAnswers{QuestionId = 5,Id = 5,Answer1 = "Geralt",Answer2 = "Ciri",Answer3 = "Roach",Answer4 = "Dandelion",CorrectAns = 1},

                 new QuizAnswers{QuestionId = 6,Id = 6,Answer1 = "Jeremy Loops",Answer2 = "Johnny Cash",Answer3 = "Brain Johnson",Answer4 = "Nickelback",CorrectAns = 3},
                 new QuizAnswers{QuestionId = 7,Id = 7,Answer1 = "Connor Youngblood",Answer2 = "Chester Charles Bennington",Answer3 = "Amy Lee",Answer4 = "Fred Durst",CorrectAns = 2},
                 new QuizAnswers{QuestionId = 8,Id = 8,Answer1 = "Queen",Answer2 = "The Beetles",Answer3 = "Beegees",Answer4 = "Papa Roach",CorrectAns = 1},
                 new QuizAnswers{QuestionId = 9,Id = 9,Answer1 = "Linkin Park",Answer2 = "Too close to touch",Answer3 = "Unlike Pluto",Answer4 = "The Beetles",CorrectAns = 4},
                 new QuizAnswers{QuestionId = 10,Id = 10,Answer1 = "Extra drum music",Answer2 = "Electic disco music",Answer3 = "Electro dance music",Answer4 = "Electro dance mix",CorrectAns = 2}
            };
        }

        public string Add(QuizAnswers entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(QuizAnswers entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(QuizAnswers entity)
        {
            throw new System.NotImplementedException();
        }


        public IEnumerable<QuizAnswers> GetAll()
        {
            return from r in QuizAnswerses
                       orderby r.QuestionId
                       select r;
        }

        public int GetCount(int startNum, int endNum)
        {
            return (from r in QuizAnswerses
                    where r.Id >= startNum && r.Id <= endNum
                    orderby r.QuestionId
                    select r).Count();
        }

        public IEnumerable<QuizAnswers> FindById(int Id)
        {
            return from r in QuizAnswerses
                   where r.Id == Id
                   select r;
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        int IRepository<QuizAnswers>.Add(QuizAnswers entity)
        {
            throw new System.NotImplementedException();
        }

        QuizAnswers IRepository<QuizAnswers>.FindById(int Id)
        {
            throw new System.NotImplementedException();
        }

        //public IEnumerable<QuizAnswers> GetAll()
        //{
        //    return from r in QuizAnswerses
        //           orderby r.QuestionId
        //           select r;

        //}
        //public IEnumerable<QuizAnswers> FetchById(int QuestionId)
        //{
        //    return from r in QuizAnswerses
        //           where r.QuizAnsId == QuestionId
        //           select r;

        //}
        //public int GetCount(int StartQ, int EndQ)
        //{
        //    return (from r in QuizAnswerses
        //            where r.QuizAnsId >= StartQ && r.QuizAnsId <= EndQ
        //            orderby r.QuestionId
        //            select r).Count();
        //}
    }
}