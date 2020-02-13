using Microsoft.EntityFrameworkCore;
using Quiz.Core;

namespace Quiz.Data
{
    public class QuizNightDbContext : DbContext
    {
        public QuizNightDbContext(DbContextOptions<QuizNightDbContext> options)
        : base(options)
        {

        }
        public DbSet<QuizClass> QuizClasses { get; set; }
        public DbSet<QuizAnswers> QuizAnswerses { get; set; }
        public DbSet<CategoryClass> CategoryClasses { get; set; }
    }
}
