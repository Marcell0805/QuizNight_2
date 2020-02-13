using Quiz.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Quiz.Core
{
    public class XmlClass : IEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string QuizName { get; set; }
        [Required, StringLength(50)]
        public string Question { get; set; }
        [Required, StringLength(50)]
        public string Answer1 { get; set; }
        [Required, StringLength(50)]
        public string Answer2 { get; set; }
        [Required, StringLength(50)]
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        [Required]
        public int CorrectAnswer { get; set; }

    }
}
