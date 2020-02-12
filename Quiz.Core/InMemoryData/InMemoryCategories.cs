﻿using System.Collections.Generic;
using System.Linq;
using Quiz.Core;

namespace Quiz.Data
{
    public class InMemoryCategories : IRepository<CategoryClass>
    {
        public List<CategoryClass> categoryClasses;
        public InMemoryCategories()
        {
            categoryClasses = new List<CategoryClass>()
            {
                new CategoryClass{Id=1,CatergoryDesc="Games"},
                new CategoryClass{Id=2,CatergoryDesc="Music"},
                new CategoryClass{Id=3,CatergoryDesc="Series"}
            };
        }

        public string Add(CategoryClass entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(CategoryClass entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CategoryClass> FindById(int Id)
        {
            return from r in categoryClasses
                   where r.Id==Id
                   orderby r.CatergoryDesc
                   select r;
        }

        public IEnumerable<CategoryClass> GetAll()
        {
            return from r in categoryClasses
                   orderby r.CatergoryDesc
                   select r;
        }

        public int GetCount(int startNum, int endNum)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void Update(CategoryClass entity)
        {
            throw new System.NotImplementedException();
        }

        int IRepository<CategoryClass>.Add(CategoryClass entity)
        {
            throw new System.NotImplementedException();
        }

        CategoryClass IRepository<CategoryClass>.FindById(int Id)
        {
            throw new System.NotImplementedException();
        }

        //IEnumerable<CategoryClass> IQuizCategories.GetAll()
        //{
        //    return from r in categoryClasses
        //           orderby r.CatergoryDesc
        //           select r;
        //}
    }
}
