using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.ServiceModel;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Linq;

namespace Chapter4.Obj3
{
    public static class Listing_4_067
    {
        public static void RunMain()
        {
            var path = "test.xml";
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("{0} deleted", path);
            }

            XElement root = new XElement("Root", new List<XElement>
            {
                new XElement("Child1"),
                new XElement("Child2"),
                new XElement("Child3")
            },
           new XAttribute("MyAttribute", 42));
            root.Save(path);
            Console.WriteLine("{0} created:", path);
            Console.WriteLine(root.ToString());

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
