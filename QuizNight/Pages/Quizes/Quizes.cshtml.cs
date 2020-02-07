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
        private readonly IQuizData _quizData;
        private readonly IQuizAnswer _quizAnswer;
        private readonly IQuizCategories quizCategories;

        public string Message { get; set; }
        public IEnumerable<QuizClass> Quizes { get; set; }
        public IEnumerable<QuizAnswers> QuizAnswers { get; set; }
        public IEnumerable<QuizAnswers> QuizAnsweredAnswerses { get; set; }
        public IEnumerable<CategoryClass> categoryClasses{ get; set; }
        public List<QuizAnswers> QuizAnswersList { get; set; }
        public List<CategoryClass> CatList { get; set; }

        public int ListCount;
                
        public int CatSelectedId { get; set; }
        public int AnswerCount;

        public QuizesModel(IConfiguration config,IQuizData quizData,IQuizAnswer quizAnswer,IQuizCategories quizCategories)
        {
            this.config = config;
            _quizData = quizData;
            _quizAnswer = quizAnswer;
            this.quizCategories = quizCategories;
            QuizAnswersList = new List<QuizAnswers>();
            CatList = new List<CategoryClass>();
        } 
        public void OnGet()
        {
            categoryClasses = quizCategories.GetAll();
            CatList.AddRange(categoryClasses);
        }
        public void OnPost(int CatIdValue, string answer="")
        {
            if (!string.IsNullOrEmpty(answer))
            {

                Quizes = _quizData.GetAll();
                categoryClasses = quizCategories.GetAll();
                QuizAnswers = _quizAnswer.GetAll();
                String[] Answer = answer.Split(";");
                CatSelectedId = GetCatList(int.Parse(Answer[1]));
                Quizes = _quizData.FetchByCatId(CatSelectedId);
                foreach (var item in Quizes)
                {
                    QuizAnswers = _quizAnswer.FetchById(item.QuestionId);
                    QuizAnswersList.AddRange(QuizAnswers);
                }

                foreach (var answerChosen in QuizAnswers)
                {
                    if (answerChosen.CorrectAns ==int.Parse(Answer[0]))
                    {
                        AnswerCount++;
                    }
                }


            }
            else
            {
                if (CatIdValue != 0)
                {
                    Quizes = _quizData.FetchByCatId(CatIdValue);
                    foreach (var item in Quizes)
                    {
                        QuizAnswers = _quizAnswer.FetchById(item.QuestionId);
                        QuizAnswersList.AddRange(QuizAnswers);
                    }
                }
                categoryClasses = quizCategories.GetAll();
            }
            CatList.AddRange(categoryClasses);

        }
        public int GetCatList(int questId)
        {
            return (from q in Quizes
                join cat in categoryClasses on q.CatId equals cat.CatId
                    join a in QuizAnswers on q.QuestionId equals a.QuestionId
                    where a.QuestionId>= questId
                orderby cat.CatergoryDesc
                select cat.CatId).FirstOrDefault();
        }
    }
}