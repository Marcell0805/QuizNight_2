using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

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
