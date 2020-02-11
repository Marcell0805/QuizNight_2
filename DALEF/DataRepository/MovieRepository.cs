using Quiz.Core;
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

        public IEnumerable<movieQuizQuiz> List
        {
            get
            {
                var movieQuiz = xmlToClass.FromXml<movieQuiz>(fileLocation);
                return movieQuiz.quiz;
            }
        }

        public IEnumerable<movieQuizQuiz> GetAll
        {
            get
            {
                var movieQuiz = xmlToClass.FromXml<movieQuiz>(fileLocation);
                return movieQuiz.quiz;
            }
        }

        public string Add(movieQuizQuiz entity)
        {
            entity.Id = Guid.NewGuid().ToString();
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

        public movieQuizQuiz FindById(string Id)
        {
            var movieQuiz = xmlToClass.FromXml<movieQuiz>(fileLocation);
            return movieQuiz.quiz.FirstOrDefault(t => t.Id == Id);
        }

        public int GetCount(int startNum, int endNum)
        {
            throw new NotImplementedException();
        }
    }
}
