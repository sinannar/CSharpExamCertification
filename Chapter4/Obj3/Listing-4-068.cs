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
    public static class Listing_4_068
    {
        public static void RunMain()
        {
            String xml = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
                            <people>
                                <person firstname=""John"" lastname=""Doe"">
                                    <contactdetails>
                                        <emailaddress>john@unknown.com</emailaddress>
                                    </contactdetails>
                                </person>
                                <person firstname=""Jane"" lastname=""Doe"">
                                    <contactdetails>
                                        <emailaddress>jane@unknown.com</emailaddress>
                                        <phonenumber>001122334455</phonenumber>
                                    </contactdetails>
                                </person>
                                <person firstname=""Albert"" lastname=""Einstein"">
                                    <contactdetails>
                                        <emailaddress>albert@unknown.com</emailaddress>
                                        <phonenumber>001111111111</phonenumber>
                                    </contactdetails>
                                </person>
                            </people>";
            XElement root = XElement.Parse(xml);

            // Using XML in a procedural way
            Console.WriteLine("Using XML in a procedural way");
            foreach (XElement p in root.Descendants("Person"))
            {
                string name = (string)p.Attribute("firstname") + (string)p.Attribute("lastname ");
                p.Add(new XAttribute("IsMale", name.Contains("John")));
                XElement contactsDetails = p.Element("contactdetails");
                if (!contactsDetails.Descendants("phonenumber").Any())
                {
                    contactsDetails.Add(new XElement("phonenumber", "001122334455"));
                }
            }

            Console.WriteLine(root.ToString());
            Console.WriteLine();
        }
    }
}
