
using Quiz.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DALEF.DataRepository
{
    public class MovieRepository : IRepository<movieQuizQuiz>
    {
        //todo move to config file
        private const string fileLocation = @"C:\vsprojects\xmlTest\xmlRepository\data.xml";
        public int Add(movieQuizQuiz entity)
        {
            entity.Id = 1;
            //entity.Id = Guid.NewGuid().ToString();
            var movieQuiz = xmlToClass.FromXml<movieQuiz>(fileLocation);

            var quizs = movieQuiz.quiz.ToList();
            quizs.Add(entity);
            movieQuiz.quiz = quizs.ToArray();

            xmlToClass.ToXMLFile(movieQuiz);

            return entity.Id;
        }

        public void Delete(movieQuizQuiz entity)
        {
            var movieQuiz = xmlToClass.FromXml<movieQuiz>(fileLocation);
            var quizs = movieQuiz.quiz.ToList();
            var index = Array.FindIndex(movieQuiz.quiz, q => q.Id == entity.Id);
            quizs.RemoveAt(index);

            movieQuiz.quiz = quizs.ToArray();

            xmlToClass.ToXMLFile(movieQuiz);
        }

        public void Update(movieQuizQuiz entity)
        {
            var movieQuiz = xmlToClass.FromXml<movieQuiz>(fileLocation);
            var index = Array.FindIndex(movieQuiz.quiz, q => q.Id == entity.Id);
            movieQuiz.quiz[index] = entity;

            xmlToClass.ToXMLFile(movieQuiz);
        }


        public int GetCount(int startNum, int endNum)
        {
            throw new NotImplementedException();
        }


        public void Save()
        {
            throw new NotImplementedException();
        }

        public movieQuizQuiz FindById(int Id)
        {
            var movieQuiz = xmlToClass.FromXml<movieQuiz>(fileLocation);
            var ListQuizXml = movieQuiz.quiz.FirstOrDefault(t => t.Id == Id);
            return ListQuizXml;
        }

        public IEnumerable<movieQuizQuiz> GetAll()
        {
            var movieQuiz = xmlToClass.FromXml<movieQuiz>(fileLocation);
            return movieQuiz.quiz;
        }
    }
}
