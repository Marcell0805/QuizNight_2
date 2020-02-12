using Quiz.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Data
{
    public interface IRepository<T> where T:IEntity 
    {
        int Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        IEnumerable<T> GetAll();
        T FindById(int Id);
        void Save();
        int GetCount(int startNum, int endNum);
    }
}
