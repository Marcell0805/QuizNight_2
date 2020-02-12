using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Quiz.Data;

namespace QuizNight
{
    public class XmlDataResultModel : PageModel
    {
        public IEnumerable<movieQuizQuiz> movieQuizList { get; set; }
        public List<movieQuizQuiz> QuizAnswersList { get; set; }
        public IConfiguration Config { get; }
        public IRepository<movieQuizQuiz> Movies { get; }

        public XmlDataResultModel(IConfiguration config, IRepository<movieQuizQuiz> movies)
        {
            Config = config;
            Movies = movies;
        }
        public void OnGet()
        {

            movieQuizList = Movies.GetAll();
            //XmlSerializer serial = new XmlSerializer(typeof(movieQuiz));
            //System.IO.StreamReader reader = new System.IO.StreamReader(@"..\QuizNight\data.xml");
            //while (!reader.EndOfStream)
            //{
            //    movieQuiz b = (movieQuiz)serial.Deserialize(reader);
            //    QuizAnswersList.Add(b);
            //}
            //using (XmlReader reader = XmlReader.Create(@"..\QuizNight\data.xml"))
            //{
            //    while (reader.Read())
            //    {
            //        if (reader.IsStartElement())
            //        {
            //            //return only when you have START tag  
            //            switch (reader.Name.ToString())
            //            {
            //                case "Name":
            //                    Debug.WriteLine("Name of the Element is : " + reader.ReadString());
            //                    break;
            //                case "Location":
            //                    Debug.WriteLine("Your Location is : " + reader.ReadString());
            //                    break;
            //            }
            //        }
            //        Console.WriteLine("");
            //    }
            //}
        }
    }
}