using Quiz.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Data
{
    public interface IRepository<T> where T:IEntity 
    {
        string Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> FindById(int Id);
        int GetCount(int startNum, int endNum);
    }
}
