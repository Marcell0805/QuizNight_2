using System.Collections.Generic;
using System.Linq;
using Quiz.Core;

namespace Quiz.Data
{
    public interface IQuizCategories
    {
        IEnumerable<CategoryClass> GetAll();
    }
    public class InMemoryCategories : IQuizCategories
    {
        public List<CategoryClass> categoryClasses;
        public InMemoryCategories()
        {
            categoryClasses = new List<CategoryClass>()
            {
                new CategoryClass{CatId=1,CatergoryDesc="Games"},
                new CategoryClass{CatId=2,CatergoryDesc="Music"},
                new CategoryClass{CatId=3,CatergoryDesc="Series"}
            };
        }
        IEnumerable<CategoryClass> IQuizCategories.GetAll()
        {
            return from r in categoryClasses
                   orderby r.CatergoryDesc
                   select r;
        }
    }
}
