using System.Collections.Generic;
using Quiz.Core;

namespace Quiz.Data
{
    public interface IQuizCategories
    {
        IEnumerable<CategoryClass> GetAll();
    }
}
