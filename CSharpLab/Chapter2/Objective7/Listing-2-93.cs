using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;

namespace CSharpLab.Chapter2.Objective7
{
    public static class Listing_2_93
    {
        public static void RunMain()
        {
            string value = "My Sample Value";
            string subString = value.Substring(3, 6); // Returns ‘Sample’

            Console.WriteLine(subString);
        }
    }
}


