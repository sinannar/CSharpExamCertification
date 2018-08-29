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

namespace Chapter4.Obj3
{
    public static class Listing_4_050
    {
        public static void RunMain()
        {
            var people = new List<Person>
            {
                new Person
                {
                    FirstName = "John",
                    LastName = "Doe"
                },
                new Person
                {
                    FirstName = "Jane",
                    LastName = "Doe"
                },
            };
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}