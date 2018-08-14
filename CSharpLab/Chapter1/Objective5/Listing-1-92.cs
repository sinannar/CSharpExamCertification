using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective5
{
    public static class Listing_1_92
    {
        public static void RunMain()
        {
            while (true)
            {
                string s = Console.ReadLine();
                
                try
                {
                    int i = int.Parse(s);
                    if (i == 42)
                    {
                        Environment.FailFast("Special number entered");
                    }
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("You need to enter a value");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"{s} is not a valid number, please try again");
                }
                finally
                {
                    Console.WriteLine("Program complete");
                }
            }
        }
    }
}
