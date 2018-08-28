using System;
using System.Collections.Generic;
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

namespace Chapter4.Obj2
{
    public static class Listing_4_027
    {
        public static void RunMain()
        {
            string connectionString = @"Persist Security Info=False;Integrated Security=true;Initial Catalog=Northwind;server=(local)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Execute operations agains the database
            } // Connection is automatically closed

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }        
    }
}