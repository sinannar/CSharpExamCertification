using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace CSharpLab.Chapter2.Objective2
{
    public static class Listing_2_21
    {
        public static void RunMain()
        {
            HttpClient client = new HttpClient();
            object o = client;
            IDisposable d = client;

            Console.WriteLine("client = {0}", client);
            Console.WriteLine("o = {0}", o);
            Console.WriteLine("d = {0}", d);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }        
    }   
}
