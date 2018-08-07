using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective3
{
    public static class Listing_1_50
    {
        public static void RunMain()
        {
            Process("Venture");
            Process("venture");
        }

        public static void Process(string input)
        {
            bool result = (input != null) && (input.StartsWith("v"));
            Console.WriteLine(input + " => " + result);
        }
    }
}
