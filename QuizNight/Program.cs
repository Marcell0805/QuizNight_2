using DALEF.DataRepository;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Quiz.Data;
using System.Linq;

namespace QuizNight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //IRepository<movieQuizQuiz> s = new MovieRepository();

            //var all = s.GetAll.ToList();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
