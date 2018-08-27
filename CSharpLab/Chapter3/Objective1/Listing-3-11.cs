using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Data.Entity;
using System.Globalization;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace CSharpLab.Chapter3.Objective1
{
    public static class Listing_3_11
    {
        // Valid zipcodes: 1234AB | 1234 AB | 1001 AB
        public static void RunMain()
        {
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex(@"[ ]{2,}", options);

            string input = "1 2 3 4  5   6         7";
            Console.WriteLine("Start input is {0}", input);
            string result = regex.Replace(input, " ");

            Console.WriteLine("Parsed input is {0}", result);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
