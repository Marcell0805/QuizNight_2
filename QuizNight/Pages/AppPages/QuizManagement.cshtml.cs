using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Quiz.Core;
using Quiz.Data;
using System.Collections.Generic;
using System.Linq;

namespace QuizNight.Pages.Quizes
{
    public class QuizManagementModel : PageModel
    {
        private IConfiguration config;
        public string Message { get; set; }
        [TempData]
        public string Error { get; set; }
        public IRepository<movieQuizQuiz> Movies { get; set; }
        public List<movieQuizQuiz> MovieList { get; set; }
        [BindProperty]
        public List<bool> CorrectNumber { get; set; }
        [BindProperty]
        public XmlClass MovieModel { get; set; }
        public IEnumerable<XmlClass> MovieModelList { get; set; }
        public QuizManagementModel(IConfiguration config, IRepository<movieQuizQuiz> movies)
        {
            Movies = movies;
            this.config = config;
        }
        public IActionResult OnGet()
        {
            MovieModel = new XmlClass();
            CorrectNumber = new List<bool>(new bool[4]);
            return Page();
        }
        public IActionResult OnPost()
        {
            var saved = AddingTheNewQuestion();
            if (saved == 0)
            {
                return Page();
            }
            else
            {
                return RedirectToPage("/Index");
            }

        }

        private int AddingTheNewQuestion()
        {

            if (CorrectNumber.Contains(true))
            {

                if (MovieModel.Id == 0 && ModelState.IsValid)
                {
                    int Answ = GetCorrectAnswer();
                    var lastId = GetLastId();
                    movieQuizQuiz updater = new movieQuizQuiz();

                    movieQuizQuizQuestion[] movQArr = new movieQuizQuizQuestion[1];

                    MovieModel.CorrectAnswer = Answ;

                    updater.Id = lastId++;
                    updater.Name = MovieModel.QuizName;
                    updater.questions = movQArr;

                    movQArr[0] = new movieQuizQuizQuestion();
                    movQArr[0].Text = MovieModel.Question;
                    movQArr[0].answers = new movieQuizQuizQuestionAnswer[4];

                    movQArr[0].answers[0] = new movieQuizQuizQuestionAnswer();
                    movQArr[0].answers[0].Text = MovieModel.Answer1;

                    movQArr[0].answers[1] = new movieQuizQuizQuestionAnswer();
                    movQArr[0].answers[1].Text = MovieModel.Answer2;

                    movQArr[0].answers[2] = new movieQuizQuizQuestionAnswer();
                    movQArr[0].answers[2].Text = MovieModel.Answer3;

                    movQArr[0].answers[3] = new movieQuizQuizQuestionAnswer();
                    movQArr[0].answers[3].Text = MovieModel.Answer4;

                    movQArr[0].answers[Answ].IsCorrect = true;

                    Movies.Add(updater);
                    return 1;
                }

            }
            else
            {
                TempData["Error"] = "Please select a correct answer";
            }
            return 0;
        }

        private int GetCorrectAnswer()
        {
            for (int i = 0; i < CorrectNumber.Count; i++)
            {
                bool item = CorrectNumber[i];
                if (item)
                {
                    return i;
                }
            }
            return 0;
        }


        private int GetLastId()
        {
            MovieList = Movies.GetAll().ToList();
            var Id = MovieList.Count();
            return Id;
        }
    }
}