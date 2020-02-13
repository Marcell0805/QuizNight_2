using Quiz.Data.Interfaces;

namespace Quiz.Core
{
    public class QuizAnswers : IEntity
    {
        public int QuestionId { get; set; }
        public int Id { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }

        public int CorrectAns { get; set; }
    }
}
