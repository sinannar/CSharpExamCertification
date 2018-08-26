using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;

namespace CSharpLab.Chapter2.Objective7
{
    public static class Listing_2_89
    {
        public static void RunMain()
        {
            var stringWriter = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(stringWriter))
            {
                writer.WriteStartElement("book");
                writer.WriteStartElement("a");
                writer.WriteStartElement("a");
                writer.WriteStartElement("b");
                writer.WriteElementString("price", "19.95");
                writer.WriteEndElement();
                writer.Flush();
            }
            string xml = stringWriter.ToString();
            Console.WriteLine(xml);
            Console.WriteLine("-------");
        }
    }
}


