using Quiz.Data.Interfaces;

namespace Quiz.Core
{
    public class CategoryClass : IEntity
    {
        public int Id { get; set; }
        public string CatergoryDesc { get; set; }
    }
}
