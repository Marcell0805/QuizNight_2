using Quiz.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz.Data
{
    public class InMemoryQuizes : IRepository<QuizClass>
    {
        private List<QuizClass> quizes;
        private List<QuizAnswers> quizesAnswers;
        public InMemoryQuizes()
        {

            quizes = new List<QuizClass>()
            {
                new QuizClass{Id = 1,CatId=1,Question = "What is the name of the first assasin in the assasins franchise?",QuestionAnswer = 2},
                new QuizClass{Id = 2,CatId=1,Question = "What is the name charcter of the new Doom game's ?",QuestionAnswer = 4},
                new QuizClass{Id = 3,CatId=1,Question = "What is the name of the snowman in Frozen?",QuestionAnswer = 2},
                new QuizClass{Id = 4,CatId=1,Question = "When will Cyberpunk come out?",QuestionAnswer = 2},
                new QuizClass{Id = 5,CatId=1,Question = "What is the name of the male witcher that you play in the Witcher franchise?",QuestionAnswer = 2},

                new QuizClass{Id = 6,CatId=2,Question = "What is the main singers name of ACDC?",QuestionAnswer = 2},
                new QuizClass{Id = 7,CatId=2,Question = "What is the main singers name of Linkin Park?",QuestionAnswer = 4},
                new QuizClass{Id = 8,CatId=2,Question = "Who sings We will rock you?",QuestionAnswer = 2},
                new QuizClass{Id = 9,CatId=2,Question = "What group sings Staying alive?",QuestionAnswer = 2},
                new QuizClass{Id = 10,CatId=2,Question = "What does EDM stand for?",QuestionAnswer = 2}
            };
            quizesAnswers = new List<QuizAnswers>()
            {
                 new QuizAnswers{Id = 1,QuestionId = 1,Answer1 = "Jeff",Answer2 = "Altair",Answer3 = "Etzio",Answer4 = "Susan",CorrectAns = 2},
                 new QuizAnswers{Id = 2,QuestionId = 2,Answer1 = "Doom Slayer",Answer2 = "Doom Guy",Answer3 = "Doom Doom",Answer4 = "Dom",CorrectAns = 1},
                 new QuizAnswers{Id = 3,QuestionId = 3,Answer1 = "Olaf",Answer2 = "Frosty",Answer3 = "Icy",Answer4 = "Snowy",CorrectAns = 1},
                 new QuizAnswers{Id = 4,QuestionId = 4,Answer1 = "2077",Answer2 = "2030",Answer3 = "2022",Answer4 = "2020",CorrectAns = 4},
                 new QuizAnswers{Id = 5,QuestionId = 5,Answer1 = "Geralt",Answer2 = "Ciri",Answer3 = "Roach",Answer4 = "Dandelion",CorrectAns = 1},

                 new QuizAnswers{Id = 6,QuestionId = 6,Answer1 = "Jeremy Loops",Answer2 = "Johnny Cash",Answer3 = "Brain Johnson",Answer4 = "Nickelback",CorrectAns = 3},
                 new QuizAnswers{Id = 7,QuestionId = 7,Answer1 = "Connor Youngblood",Answer2 = "Chester Charles Bennington",Answer3 = "Amy Lee",Answer4 = "Fred Durst",CorrectAns = 2},
                 new QuizAnswers{Id = 8,QuestionId = 8,Answer1 = "Queen",Answer2 = "The Beetles",Answer3 = "Beegees",Answer4 = "Papa Roach",CorrectAns = 1},
                 new QuizAnswers{Id = 9,QuestionId = 9,Answer1 = "Linkin Park",Answer2 = "Too close to touch",Answer3 = "Unlike Pluto",Answer4 = "The Beetles",CorrectAns = 4},
                 new QuizAnswers{Id = 10,QuestionId = 10,Answer1 = "Extra drum music",Answer2 = "Electric disco music",Answer3 = "Electro dance music",Answer4 = "Electro dance mix",CorrectAns = 2}
            };
        }

        public int Add(QuizClass entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(QuizClass entity)
        {
            throw new NotImplementedException();
        }

        public QuizClass FindById(int Id)
        {
            var quizClass = quizes.FirstOrDefault(t => t.Id == Id);
            return quizClass;
        }

        public IEnumerable<QuizClass> GetAll()
        {
            return from r in quizes
                   join ans in quizesAnswers on r.Id equals ans.QuestionId
                   orderby r.Id
                   select r;
        }

        public int GetCount(int startNum, int endNum)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(QuizClass entity)
        {
            throw new NotImplementedException();
        }


        //public IEnumerable<QuizClass> GetAll()
        //{
        //    return from r in quizes
        //           join ans in quizesAnswers on r.QuestionId equals ans.QuestionId
        //           orderby r.QuestionId
        //        select r;

        //}
        //public IEnumerable<QuizClass> FetchByCatId(int CatId)
        //{
        //    return from r in quizes
        //           where r.CatId == CatId
        //           join ans in quizesAnswers on r.QuestionId equals ans.QuestionId
        //           orderby r.QuestionId
        //           select r;
        //}
    }
}
