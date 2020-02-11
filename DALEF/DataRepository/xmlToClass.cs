using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace DALEF.DataRepository
{
    public class xmlToClass
    {

        internal static T FromXml<T>(String xmlLocation)
        {

            string xml = File.ReadAllText(xmlLocation);

            T returnedXmlClass = default(T);

            try
            {
                using (TextReader reader = new StringReader(xml))
                {
                    try
                    {
                        returnedXmlClass =
                            (T)new XmlSerializer(typeof(T)).Deserialize(reader);
                    }
                    catch (InvalidOperationException)
                    {
                        // String passed is not XML, simply return defaultXmlClass
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return returnedXmlClass;
        }

        internal static string ToXML(object instance)
        {
            using (var stringwriter = new StringWriter())
            {
                var serializer = new XmlSerializer(instance.GetType());
                serializer.Serialize(stringwriter, instance);
                return stringwriter.ToString();
            }
        }

        internal static void ToXMLFile(object instance)
        {
            XmlSerializer writer = new XmlSerializer(instance.GetType());

            //throw new Exception("Change file location");
            var path = @"C:\vsprojects\xmlTest\xmlRepository\data.xml";
            using (FileStream file = File.Create(path))
            {
                writer.Serialize(file, instance);
            }
        }

    }
}
