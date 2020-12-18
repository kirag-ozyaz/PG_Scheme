using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Xml.Serialization;
using System.Data;

namespace NotificationOfRepairs.Classes
{
 
    public class Serializer
    {
        public T Deserialize<T>(string input) where T : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }

        public string Serialize<T>(T ObjectToSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, ObjectToSerialize);
                return textWriter.ToString();
            }
        }
    }
}
// https://blog.rc21net.ru/%D1%81%D0%B5%D1%80%D0%B8%D0%B0%D0%BB%D0%B8%D0%B7%D0%B0%D1%86%D0%B8%D1%8F-serialization-%D0%B2-c-sharp/
// https://www.codeproject.com/Articles/1163664/Convert-XML-to-Csharp-Object

// https://www.codeproject.com/Articles/483055/XML-Serialization-and-Deserialization-Part-1
// https://www.codeproject.com/Articles/487571/XML-Serialization-and-Deserialization-Part-2
//Serializer ser = new Serializer();
//string path = string.Empty;
//string xmlInputData = string.Empty;
//string xmlOutputData = string.Empty;

//// EXAMPLE 1
//path = Directory.GetCurrentDirectory() + @"\Customer.xml";
//xmlInputData = File.ReadAllText(path);

//Customer customer = ser.Deserialize<Customer>(xmlInputData);
//xmlOutputData = ser.Serialize<Customer>(customer)

