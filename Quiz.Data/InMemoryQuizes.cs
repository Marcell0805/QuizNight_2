using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml;
using System.Xml.XPath;
using Quiz.Core;

namespace Quiz.Data
{
    public class InMemoryQuizes : IQuizData
    {
        private List<QuizClass> quizes;
        private List<QuizAnswers> quizesAnswers;
        public  InMemoryQuizes()
        {
            ReadXML();
            quizes = new List<QuizClass>()
            {
                new QuizClass{QuestionId = 1,CatId=1,Question = "What is the name of the first assasin in the assasins franchise?",QuestionAnswer = 2},
                new QuizClass{QuestionId = 2,CatId=1,Question = "What is the name charcter of the new Doom game's ?",QuestionAnswer = 4},
                new QuizClass{QuestionId = 3,CatId=1,Question = "What is the name of the snowman in Frozen?",QuestionAnswer = 2},
                new QuizClass{QuestionId = 4,CatId=1,Question = "When will Cyberpunk come out?",QuestionAnswer = 2},
                new QuizClass{QuestionId = 5,CatId=1,Question = "What is the name of the male witcher that you play in the Witcher franchise?",QuestionAnswer = 2},

                new QuizClass{QuestionId = 6,CatId=2,Question = "What is the main singers name of ACDC?",QuestionAnswer = 2},
                new QuizClass{QuestionId = 7,CatId=2,Question = "What is the main singers name of Linkin Park?",QuestionAnswer = 4},
                new QuizClass{QuestionId = 8,CatId=2,Question = "Who sings We will rock you?",QuestionAnswer = 2},
                new QuizClass{QuestionId = 9,CatId=2,Question = "What group sings Staying alive?",QuestionAnswer = 2},
                new QuizClass{QuestionId = 10,CatId=2,Question = "What does EDM stand for?",QuestionAnswer = 2}
            };
            quizesAnswers = new List<QuizAnswers>()
            {
                 new QuizAnswers{QuizAnsId = 1,QuestionId = 1,Ans1 = "Jeff",Ans2 = "Altair",Ans3 = "Etzio",Ans4 = "Susan",CorrectAns = 2},
                 new QuizAnswers{QuizAnsId = 2,QuestionId = 2,Ans1 = "Doom Slayer",Ans2 = "Doom Guy",Ans3 = "Doom Doom",Ans4 = "Dom",CorrectAns = 1},
                 new QuizAnswers{QuizAnsId = 3,QuestionId = 3,Ans1 = "Olaf",Ans2 = "Frosty",Ans3 = "Icy",Ans4 = "Snowy",CorrectAns = 1},
                 new QuizAnswers{QuizAnsId = 4,QuestionId = 4,Ans1 = "2077",Ans2 = "2030",Ans3 = "2022",Ans4 = "2020",CorrectAns = 4},
                 new QuizAnswers{QuizAnsId = 5,QuestionId = 5,Ans1 = "Geralt",Ans2 = "Ciri",Ans3 = "Roach",Ans4 = "Dandelion",CorrectAns = 1},

                 new QuizAnswers{QuizAnsId = 6,QuestionId = 6,Ans1 = "Jeremy Loops",Ans2 = "Johnny Cash",Ans3 = "Brain Johnson",Ans4 = "Nickelback",CorrectAns = 3},
                 new QuizAnswers{QuizAnsId = 7,QuestionId = 7,Ans1 = "Connor Youngblood",Ans2 = "Chester Charles Bennington",Ans3 = "Amy Lee",Ans4 = "Fred Durst",CorrectAns = 2},
                 new QuizAnswers{QuizAnsId = 8,QuestionId = 8,Ans1 = "Queen",Ans2 = "The Beetles",Ans3 = "Beegees",Ans4 = "Papa Roach",CorrectAns = 1},
                 new QuizAnswers{QuizAnsId = 9,QuestionId = 9,Ans1 = "Linkin Park",Ans2 = "Too close to touch",Ans3 = "Unlike Pluto",Ans4 = "The Beetles",CorrectAns = 4},
                 new QuizAnswers{QuizAnsId = 10,QuestionId = 10,Ans1 = "Extra drum music",Ans2 = "Electric disco music",Ans3 = "Electro dance music",Ans4 = "Electro dance mix",CorrectAns = 2}
            };
        }
        public void ReadXML()
        {
            DataSet data = new DataSet();
            data.ReadXml(@"\QuizNight\Quiz.Data\data.xml");
            //XPathDocument document = new XPathDocument(@"F:\QuizNight\Quiz.Data\data.xml.xml");
            //XmlDataDocument datadoc = new XmlDataDocument();
            //Infer the DataSet schema from the XML data and load the XML Data
            //datadoc.DataSet.ReadXml(sr, XmlReadMode.InferSchema);
            //DisplayTables(datadoc.DataSet);
            //DataSet mm = datadoc.DataSet;
            //Navigate Dataset;
            //XmlReaderSettings settings = new XmlReaderSettings();
            //settings.DtdProcessing = DtdProcessing.Parse;
            //XmlReader reader = XmlReader.Create(@"\QuizNight\Quiz.Data\data.xml", settings);

            //reader.MoveToContent();
            //// Parse the file and display each of the nodes.
            //while (reader.Read())
            //{
            //    switch (reader.NodeType)
            //    {
            //        case XmlNodeType.Element:
            //            System.Diagnostics.Debug.WriteLine("<{0}>", reader.Name);
            //            Console.Write("<{0}>", reader.Name);
            //            break;
            //        case XmlNodeType.Text:
            //            System.Diagnostics.Debug.WriteLine(reader.Value);
            //            break;
            //        case XmlNodeType.CDATA:
            //            System.Diagnostics.Debug.WriteLine("<![CDATA[{0}]]>", reader.Value);
            //            break;
            //        case XmlNodeType.ProcessingInstruction:
            //            System.Diagnostics.Debug.WriteLine("<?{0} {1}?>", reader.Name, reader.Value);
            //            break;
            //        case XmlNodeType.Comment:
            //            System.Diagnostics.Debug.WriteLine("<!--{0}-->", reader.Value);
            //            break;
            //        case XmlNodeType.XmlDeclaration:
            //            System.Diagnostics.Debug.WriteLine("<?xml version='1.0'?>");
            //            break;
            //        case XmlNodeType.Document:
            //            break;
            //        case XmlNodeType.DocumentType:
            //            System.Diagnostics.Debug.WriteLine("<!DOCTYPE {0} [{1}]", reader.Name, reader.Value);
            //            break;
            //        case XmlNodeType.EntityReference:
            //            System.Diagnostics.Debug.WriteLine(reader.Name);
            //            break;
            //        case XmlNodeType.EndElement:
            //            System.Diagnostics.Debug.WriteLine("</{0}>", reader.Name);
            //            break;
            //    }
            //}
        }
        public IEnumerable<QuizClass> GetAll()
        {
            return from r in quizes
                   join ans in quizesAnswers on r.QuestionId equals ans.QuestionId
                   orderby r.QuestionId
                select r;

        }
        public IEnumerable<QuizClass> FetchByCatId(int CatId)
        {
            return from r in quizes
                   where r.CatId == CatId
                   join ans in quizesAnswers on r.QuestionId equals ans.QuestionId
                   orderby r.QuestionId
                   select r;
        }
    }
}
