using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleRepositoryFrameWork.Interfaces
{
    public interface IRepository<T> where T:IEntity
    {
        IEnumerable<T> List { get; }
        string Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(string Id);
    }
}
