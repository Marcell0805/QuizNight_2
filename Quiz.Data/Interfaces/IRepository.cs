using Quiz.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Data
{
    public interface IRepository<T> where T:IEntity 
    {
        IEnumerable<T> List { get; }
        string Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetAll();
        T FindById(string Id);
        int GetCount(int startNum, int endNum);
    }
}
