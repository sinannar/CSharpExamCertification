using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace CSharpLab.Chapter2.Objective7
{
    public static class Listing_2_95
    {
        public static void RunMain()
        {
            string value = "My Custom Value";
            foreach (char c in value)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();
            foreach (string word in value.Split(' '))
            {
                Console.WriteLine(word);
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}


