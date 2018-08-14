using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective5
{
    public static class Listing_1_93
    {
        public static void RunMain()
        {
            while (true)
            {
                string s = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(s)) break;

                try
                {
                    int i = ReadAndParse();
                    Console.WriteLine($"Parsed : {i}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Messate : {ex.Message}");
                    Console.WriteLine($"StackTrace : {ex.StackTrace}");
                    Console.WriteLine($"HelpLink : {ex.HelpLink}");
                    Console.WriteLine($"InnerException : {ex.InnerException}");
                    Console.WriteLine($"TargetSite : {ex.TargetSite}");
                    Console.WriteLine($"Source : {ex.Source}");
                }
            }
        }

        private static int ReadAndParse()
        {
            string s = Console.ReadLine();
            int i = int.Parse(s);
            return i;
        }
    }
}
