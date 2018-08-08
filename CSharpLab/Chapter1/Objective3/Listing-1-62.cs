using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective3
{
    public static class Listing_1_62
    {
        public static void RunMain()
        {
            Check(Console.ReadKey().KeyChar);
        }

        public static void Check(char input)
        {
            switch(input)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine($"{input} is a vowel");
                    break;
                case 'y':
                    Console.WriteLine($"{input} is sometimes vowel");
                    break;
                default:
                    Console.WriteLine($"{input} is a consonant");
                    break;
            }
        }
    }
}
