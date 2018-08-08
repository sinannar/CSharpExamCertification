using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective3
{
    public static class Listing_1_61
    {
        public static void RunMain()
        {
            Check(Console.ReadKey().KeyChar);
        }

        public static void Check(char input)
        {
            if (input == 'a'
                || input == 'e'
                || input == 'i'
                || input == 'o'
                || input == 'u')
            {
                Console.WriteLine($"{input} is a vowel");
            }
            else
            {
                Console.WriteLine($"{input} is a consonant");
            }
        }
    }
}
