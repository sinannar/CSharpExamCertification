using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective3
{
    public static class Listing_1_49
    {
        public static void RunMain()
        {
            int value = 42;
            bool result = (0 < value) && (value < 100);

            Console.WriteLine(result);
        }
    }
}
