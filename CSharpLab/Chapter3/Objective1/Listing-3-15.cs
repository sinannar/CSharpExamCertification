using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Data.Entity;
using System.Globalization;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Schema;

namespace CSharpLab.Chapter3.Objective1
{
    public static class Listing_3_15
    {
        public static void RunMain()
        {
            string xmlPath = "Person.xml";
            string xsdPath = "Person.xsd";
            ValidateXML();

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }

        public static void ValidateXML()
        {
            string xsdPath = "Person.xsd";
            string xmlPath = "Person.xml";

            XmlReader reader = XmlReader.Create(xmlPath);
            XmlDocument document = new XmlDocument();
            document.Schemas.Add("", xsdPath);
            document.Load(reader);
            ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);
            Console.WriteLine("Validating Person.xml ...");
            document.Validate(eventHandler);
        }

        private static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    Console.WriteLine("Error: {0}", e.Message);
                    break;
                case XmlSeverityType.Warning:
                    Console.WriteLine("Warning: {0}", e.Message);
                    break;
                default:
                    break;
            }
        }
    }
}
