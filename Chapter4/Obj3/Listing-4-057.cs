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
    public static class Listing_4_057
    {
        public static void RunMain()
        {
            int[] data = { 1, 2, 5, 8, 11 };

            var result = from d in data
                         where d > 5
                         orderby d descending
                         select d;

            Console.WriteLine(string.Join(", ", result));

        }
    }
}