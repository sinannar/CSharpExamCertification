using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLab.Chapter2.Objective2
{
    public static class Listing_2_19
    {
        public static void RunMain()
        {
            string.Concat("To box or not box", 42, true);
            int i = 42;
            object o = i;
            int x = (int)o;

            Console.WriteLine(x);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }        
    }   
}
