using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace CSharpLab.Chapter2.Objective7
{
    public static class Listing_2_98
    {
        public static void RunMain()
        {
            DateTime d = new DateTime(2014, 3, 11);
            CultureInfo provider = new CultureInfo("en-US");
            Console.WriteLine(d.ToString("d", provider));
            Console.WriteLine(d.ToString("D", provider));
            Console.WriteLine(d.ToString("M", provider));
        }       
    }
}


