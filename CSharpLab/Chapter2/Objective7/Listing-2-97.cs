using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace CSharpLab.Chapter2.Objective7
{
    public static class Listing_2_97
    {
        public static void RunMain()
        {
            double cost = 1234.56;
            Console.WriteLine(cost.ToString("C", new CultureInfo("en-US")));
        }        
    }
}


