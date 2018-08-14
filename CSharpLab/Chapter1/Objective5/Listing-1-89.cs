using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective5
{
    public static class Listing_1_89
    {
        public static void RunMain()
        {
            while(true)
            {
                string s = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(s)) break;

                try
                {
                    int i = int.Parse(s);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"{s} is not a valid number, please try again");
                }
            }
        }
    }
}
