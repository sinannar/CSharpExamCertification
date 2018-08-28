using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4.Obj1
{
    public static class Listing_4_025
    {
        public static void RunMain()
        {
            var task = ExecuteMultipleRequests();

            while (!task.IsCompleted)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }

        public static async Task ExecuteMultipleRequests()
        {
            HttpClient client = new HttpClient();
            string microsoft = await client.GetStringAsync("http://www.microsoft.com");
            Console.WriteLine(microsoft);
            string msdn = await client.GetStringAsync("http://msdn.microsoft.com");
            Console.WriteLine(msdn);
            string blogs = await client.GetStringAsync("http://blogs.msdn.com");
            Console.WriteLine(blogs);

            Console.WriteLine();
        }
    }
}