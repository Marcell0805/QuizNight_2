using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml;
using System.Xml.XPath;
using Quiz.Core;

namespace Quiz.Data
{
    public class InMemoryQuizes: IRepository<QuizClass>
    {
        private List<QuizClass> quizes;
        private List<QuizAnswers> quizesAnswers;
        public  InMemoryQuizes()
        {
           
            quizes = new List<QuizClass>()
            {
                new QuizClass{QuestionId = 1,CatId=1,Question = "What is the name of the first assasin in the assasins franchise?",QuestionAnswer = 2},
                new QuizClass{QuestionId = 2,CatId=1,Question = "What is the name charcter of the new Doom game's ?",QuestionAnswer = 4},
                new QuizClass{QuestionId = 3,CatId=1,Question = "What is the name of the snowman in Frozen?",QuestionAnswer = 2},
                new QuizClass{QuestionId = 4,CatId=1,Question = "When will Cyberpunk come out?",QuestionAnswer = 2},
                new QuizClass{QuestionId = 5,CatId=1,Question = "What is the name of the male witcher that you play in the Witcher franchise?",QuestionAnswer = 2},

                new QuizClass{QuestionId = 6,CatId=2,Question = "What is the main singers name of ACDC?",QuestionAnswer = 2},
                new QuizClass{QuestionId = 7,CatId=2,Question = "What is the main singers name of Linkin Park?",QuestionAnswer = 4},
                new QuizClass{QuestionId = 8,CatId=2,Question = "Who sings We will rock you?",QuestionAnswer = 2},
                new QuizClass{QuestionId = 9,CatId=2,Question = "What group sings Staying alive?",QuestionAnswer = 2},
                new QuizClass{QuestionId = 10,CatId=2,Question = "What does EDM stand for?",QuestionAnswer = 2}
            };
            quizesAnswers = new List<QuizAnswers>()
            {
                 new QuizAnswers{QuizAnsId = 1,QuestionId = 1,Answer1 = "Jeff",Answer2 = "Altair",Answer3 = "Etzio",Answer4 = "Susan",CorrectAns = 2},
                 new QuizAnswers{QuizAnsId = 2,QuestionId = 2,Answer1 = "Doom Slayer",Answer2 = "Doom Guy",Answer3 = "Doom Doom",Answer4 = "Dom",CorrectAns = 1},
                 new QuizAnswers{QuizAnsId = 3,QuestionId = 3,Answer1 = "Olaf",Answer2 = "Frosty",Answer3 = "Icy",Answer4 = "Snowy",CorrectAns = 1},
                 new QuizAnswers{QuizAnsId = 4,QuestionId = 4,Answer1 = "2077",Answer2 = "2030",Answer3 = "2022",Answer4 = "2020",CorrectAns = 4},
                 new QuizAnswers{QuizAnsId = 5,QuestionId = 5,Answer1 = "Geralt",Answer2 = "Ciri",Answer3 = "Roach",Answer4 = "Dandelion",CorrectAns = 1},

                 new QuizAnswers{QuizAnsId = 6,QuestionId = 6,Answer1 = "Jeremy Loops",Answer2 = "Johnny Cash",Answer3 = "Brain Johnson",Answer4 = "Nickelback",CorrectAns = 3},
                 new QuizAnswers{QuizAnsId = 7,QuestionId = 7,Answer1 = "Connor Youngblood",Answer2 = "Chester Charles Bennington",Answer3 = "Amy Lee",Answer4 = "Fred Durst",CorrectAns = 2},
                 new QuizAnswers{QuizAnsId = 8,QuestionId = 8,Answer1 = "Queen",Answer2 = "The Beetles",Answer3 = "Beegees",Answer4 = "Papa Roach",CorrectAns = 1},
                 new QuizAnswers{QuizAnsId = 9,QuestionId = 9,Answer1 = "Linkin Park",Answer2 = "Too close to touch",Answer3 = "Unlike Pluto",Answer4 = "The Beetles",CorrectAns = 4},
                 new QuizAnswers{QuizAnsId = 10,QuestionId = 10,Answer1 = "Extra drum music",Answer2 = "Electric disco music",Answer3 = "Electro dance music",Answer4 = "Electro dance mix",CorrectAns = 2}
            };
        }

        public IEnumerable<QuizClass> GetAll => throw new NotImplementedException();

        public string Add(QuizClass entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(QuizClass entity)
        {
            throw new NotImplementedException();
        }

        public QuizClass FindById(string Id)
        {
            throw new NotImplementedException();
        }

        public int GetCount(int startNum, int endNum)
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
