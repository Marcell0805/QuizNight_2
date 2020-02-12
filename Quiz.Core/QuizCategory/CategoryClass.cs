using Quiz.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Core
{
    public class CategoryClass :IEntity
    {
        public int Id{ get; set; }
        public string CatergoryDesc { get; set; }
    }
}
