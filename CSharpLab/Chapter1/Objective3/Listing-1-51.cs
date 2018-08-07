using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective3
{
    public static class Listing_1_51
    {
        public static void RunMain()
        {
            bool a = true;
            bool b = false;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("a ^ a = " + (a ^ a)); // False
            Console.WriteLine("a ^ b = " + (a ^ b)); // False
            Console.WriteLine("b ^ b = " + (b ^ b)); // False
            //Console.WriteLine(a ^ a); // True
            //Console.WriteLine(a ^ b); // True
            //Console.WriteLine(b ^ b); // False
        }
    }
}
