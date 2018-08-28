using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Chapter4.Obj2
{
    public static class Listing_4_037
    {
        public static void RunMain()
        {
            
        }

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}