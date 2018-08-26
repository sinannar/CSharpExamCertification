using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;

namespace CSharpLab.Chapter2.Objective7
{
    public static class Listing_2_92
    {
        public static void RunMain()
        {
            StartsWithEndWith("<mycustominput>");
            StartsWithEndWith("a<mycustominput>");
            StartsWithEndWith("<mycustominput>a");
            StartsWithEndWith(" <mycustominput> ");
        }

        public static void StartsWithEndWith(string value)
        {
            if (value.StartsWith("<"))
            {
                Console.WriteLine($"{value} StartsWith <");
            }
            else
            {
                Console.WriteLine($"{value} is not StartsWith <");
            }

            if (value.EndsWith(">"))
            {
                Console.WriteLine($"{value} EndsWith >");
            }
            else
            {
                Console.WriteLine($"{value} is not  EndsWith >");
            }
        }
    }
}


