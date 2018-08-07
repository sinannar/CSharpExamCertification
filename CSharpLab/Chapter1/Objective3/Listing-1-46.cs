using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective3
{
    public static class Listing_1_46
    {
        public static void RunMain()
        {
            int x = 42;
            int y = 1;
            int z = 42;
            Console.WriteLine(x == y); // Displays false
            Console.WriteLine(x == z); // Displays true
        }
    }
}
