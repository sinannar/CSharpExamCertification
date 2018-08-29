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
    public static class Listing_4_066
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

            XDocument doc = XDocument.Parse(xml);
            IEnumerable<string> personsWithNumberInAlphabeticOrder = from p in doc.Descendants("person")
                                                                     where p.Descendants("phonenumber").Any()
                                                                     let name = (string)p.Attribute("firstname") + " " + (string)p.Attribute("lastname")
                                                                     orderby name
                                                                     select name;
            Console.WriteLine("Displaying all persons with numbers in alphabetic order: ");
            foreach (string s in personsWithNumberInAlphabeticOrder)
            {
                Console.WriteLine(s);
            }

        }
    }
}
