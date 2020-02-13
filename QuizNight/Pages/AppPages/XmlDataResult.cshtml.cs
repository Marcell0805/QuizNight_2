using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Quiz.Data;
using System.Collections.Generic;

namespace QuizNight
{
    public class XmlDataResultModel : PageModel
    {
        public IEnumerable<movieQuizQuiz> movieQuizList { get; set; }
        public List<movieQuizQuiz> QuizAnswersList { get; set; }
        public IConfiguration Config { get; }
        public IRepository<movieQuizQuiz> Movies { get; }

        public XmlDataResultModel(IConfiguration config, IRepository<movieQuizQuiz> movies)
        {
            Config = config;
            Movies = movies;
        }
        public void OnGet()
        {
            movieQuizList = Movies.GetAll();
        }
    }
}