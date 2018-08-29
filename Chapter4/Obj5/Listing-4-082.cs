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
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;
using System.Runtime.Serialization.Json;

namespace Chapter4.Obj5
{
    public static class Listing_4_082
    {
        public static void RunMain()
        {
            int[][] jaggedArray =
            {
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
                new int[] {42,21}
            };

            foreach(var i in jaggedArray)
            {
                foreach (var j in i)
                {
                    Console.Write("" + j + "   ");
                }
                Console.WriteLine();
            }

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
