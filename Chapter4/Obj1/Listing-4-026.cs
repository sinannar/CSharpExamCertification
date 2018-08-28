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
    public static class Listing_4_026
    {
        public static void RunMain()
        {
            var task = ExecuteMultipleRequestsInParallel();

            while (!task.IsCompleted)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }

        public static async Task ExecuteMultipleRequestsInParallel()
        {
            HttpClient client = new HttpClient();
            Task<string> microsoft = client.GetStringAsync("http://www.microsoft.com");
            Task<string> msdn = client.GetStringAsync("http://msdn.microsoft.com");
            Task<string> blogs = client.GetStringAsync("http://blogs.msdn.com");

            await Task.WhenAll(microsoft, msdn, blogs);

            Console.WriteLine(microsoft.Result);
            Console.WriteLine(msdn.Result);
            Console.WriteLine(blogs.Result);

            Console.WriteLine();
        }
    }
}