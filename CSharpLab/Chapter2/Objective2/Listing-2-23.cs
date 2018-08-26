using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace CSharpLab.Chapter2.Objective2
{
    public static class Listing_2_23
    {
        public static void RunMain()
        {
            object stream = new MemoryStream();
            MemoryStream memoryStream = (MemoryStream)stream;

            Console.WriteLine("stream = {0}", stream);
            Console.WriteLine("memoryStream = {0}", memoryStream);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }        
    }   
}
