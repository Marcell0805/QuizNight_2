using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Quiz.Core;
using Quiz.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizNight.Pages.Quizes
{
    public class QuizesModel : PageModel
    {
        private readonly IConfiguration Config;
        //Quiz Lists
        public List<QuizClass> Quizes { get; set; }
        public List<QuizAnswers> QuizAnswers { get; set; }
        public List<QuizAnswers> QuizAnswersList { get; set; }
        public List<CategoryClass> CatList { get; set; }
        //Quiz IEnums
        public IEnumerable<CategoryClass> categoryClasses { get; set; }
        public IEnumerable<movieQuizQuiz> movieQuizList { get; set; }
        public IRepository<QuizClass> Repository { get; }
        public IRepository<CategoryClass> RepositoryCatagory { get; }
        public IRepository<QuizAnswers> RepositoryAnswers { get; }
        public IRepository<movieQuizQuiz> Movies { get; }

        //Quiz page properties
        public int ListCount;
        public int CatSelectedId { get; set; }
        [TempData]
        public string AnsweredQuestions { get; set; }
        [TempData]
        public int AnswerCount { get; set; }
        [TempData]
        public string Score { get; set; }

        public QuizesModel(IConfiguration config, IRepository<QuizClass> repositoryQuiz, IRepository<CategoryClass> repositoryCatagory
            , IRepository<QuizAnswers> repositoryAnswers, IRepository<movieQuizQuiz> movies)
        {
            Config = config;
            Repository = repositoryQuiz;
            RepositoryCatagory = repositoryCatagory;
            RepositoryAnswers = repositoryAnswers;
            Movies = movies;
            QuizAnswersList = new List<QuizAnswers>();
            CatList = new List<CategoryClass>();
        }
        public void OnGet()
        {
            SetCatList();
        }

        public void Set(string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();

            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddMilliseconds(10);

            Response.Cookies.Append(key, value, option);
        }
        public void OnPost(int Id, string answer = "")
        {
            SetCatList();
            Quizes = Repository.GetAll().ToList();
            QuizAnswers = RepositoryAnswers.GetAll().ToList();

            if (!string.IsNullOrEmpty(answer))
            {
                var Answer = answer.Split(";");
                CatSelectedId = GetCatList(int.Parse(Answer[1]));
                SetQuizList(CatSelectedId);
                if (string.IsNullOrEmpty(AnsweredQuestions))
                {
                    AnsweredQuestions = "";
                }
                if (!AnsweredQuestions.Contains(Answer[0]))
                {
                    foreach (var answerChosen in QuizAnswers)
                    {
                        if (answerChosen.CorrectAns == int.Parse(Answer[0]))
                        {
                            TempData["AnswerCount"] = AnswerCount++;
                            break;
                        }
                    }
                    AnsweredQuestions += Answer[0].ToString() + " ";
                }
            }
            else
            {
                if (Id == 1 || Id == 2)
                {
                    SetQuizList(Id);
                }
                else
                {
                    movieQuizList = Movies.GetAll();
                }
            }
        }
        private void SetCatList()
        {
            categoryClasses = RepositoryCatagory.GetAll();
            CatList.AddRange(categoryClasses);
        }

        private void SetQuizList(int Id)
        {
            var QuizId = Repository.FindById(Id);
            Quizes = Quizes.Where(p => p.CatId == Id).ToList();
            foreach (var item in Quizes)
            {
                QuizAnswers = RepositoryAnswers.GetAll().ToList();
                var s = QuizAnswers.Where(p => p.Id == item.Id);
                QuizAnswersList.AddRange(s);
            }
        }

        public int GetCatList(int questId)
        {
            return (from q in Quizes
                    join cat in categoryClasses on q.CatId equals cat.Id
                    join a in QuizAnswers on q.Id equals a.Id
                    where a.QuestionId >= questId
                    orderby cat.CatergoryDesc
                    select cat.Id).FirstOrDefault();
        }
        public IActionResult OnGetShowResult()
        {
            Score = "Your score is " + "" + AnswerCount + " !";
            TempData["Score"] = "Your score is " + "" + AnswerCount + " !";
            return RedirectToPage("/Index");
        }
    }
}