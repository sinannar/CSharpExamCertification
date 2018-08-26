using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLab.Chapter2.Objective2
{
    public static class Listing_2_20
    {
        public static void RunMain()
        {
            int i = 42;
            double d = i;

            Console.WriteLine("d = {0}", d);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }        
    }   
}
