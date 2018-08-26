using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace CSharpLab.Chapter2.Objective2
{
    public static class Listing_2_22
    {
        public static void RunMain()
        {
            double x = 1234.7;
            int a;
            double y;
            // Cast double to int
            a = (int)x;
            y = a;

            Console.WriteLine("x = {0}", x);
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("y = {0}", y);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }        
    }   
}
