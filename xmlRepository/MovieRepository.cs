/*Created
  I tried to recreate a previous XML reader and assign it using a repository, but time didn't allow me to finish 
 */

/*using SimpleRepositoryFrameWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace xmlRepository
{
    public class MovieXmlRepository : IRepository<movieQuizQuiz>
    {
        //todo move to config file
        private const string fileLocation = @"c:\data.xml";
       
        public IEnumerable<movieQuizQuiz> List {
            get
            {
                var movieQuiz= xmlHelper.FromXml<movieQuiz>(fileLocation);                
                return movieQuiz.quiz;
            }
        }

        public string Add(movieQuizQuiz entity)
        {
            entity.Id = Guid.NewGuid().ToString();
            var movieQuiz = xmlHelper.FromXml<movieQuiz>(fileLocation);

            var quizs= movieQuiz.quiz.ToList();
            quizs.Add(entity);
            movieQuiz.quiz = quizs.ToArray();

            xmlHelper.ToXMLFile(movieQuiz);

            return entity.Id;
        }

        public void Delete(movieQuizQuiz entity)
        {
            var movieQuiz = xmlHelper.FromXml<movieQuiz>(fileLocation);
            var quizs = movieQuiz.quiz.ToList();
            var index = Array.FindIndex(movieQuiz.quiz, q => q.Id == entity.Id);
            quizs.RemoveAt(index);

            movieQuiz.quiz = quizs.ToArray();

            xmlHelper.ToXMLFile(movieQuiz);
        }        

        public void Update(movieQuizQuiz entity)
        {
            var movieQuiz = xmlHelper.FromXml<movieQuiz>(fileLocation);
            var index = Array.FindIndex(movieQuiz.quiz, q => q.Id == entity.Id);
            movieQuiz.quiz[index] = entity;            

            xmlHelper.ToXMLFile(movieQuiz);
        }

        public movieQuizQuiz FindById(string Id)
        {
            var movieQuiz = xmlHelper.FromXml<movieQuiz>(fileLocation);        
            return movieQuiz.quiz.FirstOrDefault(t => t.Id == Id);            
        }
    }
}
*/