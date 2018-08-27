using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Data.Entity;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CSharpLab.Chapter3.Objective1
{
    public static class Listing_3_10
    {
        // Valid zipcodes: 1234AB | 1234 AB | 1001 AB
        public static void RunMain()
        {
            var zipCodes = new[] { "1234AB", "1234 AB", "1001 AB" };

            foreach (var item in zipCodes)
            {
                Console.WriteLine($"{item} is valid:{ValidateZipCodeRegEx(item)}");
            }
        }

        public static bool ValidateZipCodeRegEx(string zipCode)
        {
            Match match = Regex.Match(zipCode, @"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$", RegexOptions.IgnoreCase);
            return match.Success;
        }
    }
}
