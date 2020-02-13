using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Quiz.Core;
using Quiz.Data;

namespace QuizNight.Pages.Quizes
{
    public class QuizesModel : PageModel
    {
        private readonly IConfiguration config;
        public List<QuizClass> Quizes { get; set; }
        public List<QuizAnswers> QuizAnswers { get; set; }
        public IEnumerable<QuizAnswers> QuizAnsDetail { get; set; }
        public IEnumerable<CategoryClass> categoryClasses{ get; set; }
        public List<QuizAnswers> QuizAnswersList { get; set; }
        public List<CategoryClass> CatList { get; set; }

        public int ListCount;
        public IEnumerable<movieQuizQuiz> movieQuizList { get; set; }
        public int CatSelectedId { get; set; }
        public IRepository<QuizClass> Repository { get; }
        public IRepository<CategoryClass> RepositoryCatagory { get; }
        public IRepository<QuizAnswers> RepositoryAnswers { get; }
        public IRepository<movieQuizQuiz> Movies { get; }

        public int AnswerCount;

        public QuizesModel(IConfiguration config,IRepository<QuizClass> repositoryQuiz, IRepository<CategoryClass> repositoryCatagory
            , IRepository<QuizAnswers> repositoryAnswers, IRepository<movieQuizQuiz> movies)
        {
            this.config = config;
            Repository = repositoryQuiz;
            RepositoryCatagory = repositoryCatagory;
            RepositoryAnswers = repositoryAnswers;
            Movies = movies;
            QuizAnswersList = new List<QuizAnswers>();
            CatList = new List<CategoryClass>();
        } 
        public void OnGet()
        {
            categoryClasses = RepositoryCatagory.GetAll();
            CatList.AddRange(categoryClasses);
        }
        public void OnPost(int Id, string answer="")
        {
            categoryClasses = RepositoryCatagory.GetAll();
            Quizes = Repository.GetAll().ToList();
            QuizAnswers = RepositoryAnswers.GetAll().ToList();
            if (!string.IsNullOrEmpty(answer))
            {                
                String[] Answer = answer.Split(";");
                CatSelectedId = GetCatList(int.Parse(Answer[1]));
                var a = Repository.FindById(CatSelectedId);
                foreach (var answerChosen in QuizAnswers)
                {
                    if (answerChosen.CorrectAns ==int.Parse(Answer[0]))
                    {
                        AnswerCount++;
                    }
                }
                SetQuizList(Id);
            }
            else
            {
                if (Id==1|| Id == 2)
                {
                    SetQuizList(Id);
                }
                else
                {
                    movieQuizList = Movies.GetAll();
                }
            }
            CatList.AddRange(categoryClasses);

        }

        private void SetQuizList(int Id)
        {
            var QuizId = Repository.FindById(Id);
            Quizes = Quizes.Where(p => p.CatId == Id).ToList();
            foreach (var item in Quizes)
            {
                QuizAnswers = RepositoryAnswers.GetAll().ToList();
                var s = QuizAnswers.Where(p => p.QuestionId == item.Id);
                QuizAnswersList.AddRange(s);
            }
        }

        public int GetCatList(int questId)
        {
            return (from q in Quizes
                join cat in categoryClasses on q.CatId equals cat.Id
                    join a in QuizAnswers on q.Id equals a.Id
                    where a.QuestionId>= questId
                orderby cat.CatergoryDesc
                select cat.Id).FirstOrDefault();
        }
    }
}