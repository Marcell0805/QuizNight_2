using Quiz.Data.Interfaces;
namespace Quiz.Core
{
    public partial class QuizClass : IEntity
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public int QuestionAnswer { get; set; }
        public int CatId { get; set; }
    }
}
