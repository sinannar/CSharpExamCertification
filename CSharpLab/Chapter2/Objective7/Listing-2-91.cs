using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;

namespace CSharpLab.Chapter2.Objective7
{
    public static class Listing_2_91
    {
        public static void RunMain()
        {
            string value = "My Sample Value";
            int indexOfp = value.IndexOf('p'); // returns 6
            int lastIndexOfm = value.LastIndexOf('m'); // returns 5

            Console.WriteLine(indexOfp);
            Console.WriteLine(lastIndexOfm);
        }
    }
}


