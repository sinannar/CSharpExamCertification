using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Data.Entity;
using System.Globalization;

namespace CSharpLab.Chapter3.Objective1
{
    public static class Listing_3_09
    {
        // Valid zipcodes: 1234AB | 1234 AB | 1001 AB
        public static void RunMain()
        {
            var zipCodes = new[] { "1234AB", "1234 AB", "1001 AB" };

            foreach (var item in zipCodes)
            {
                Console.WriteLine($"{item} is valid:{ValidateZipCode(item)}");
            }
        }

        public static bool ValidateZipCode(string zipCode)
        {
            if (zipCode.Length < 6)
                return false;

            string numberPart = zipCode.Substring(0, 4);
            int number;

            if (!int.TryParse(numberPart, out number))
                return false;

            string characterPart = zipCode.Substring(4);

            if (numberPart.StartsWith("0"))
                return false;

            if (characterPart.Trim().Length < 2)
                return false;

            if (characterPart.Length == 3 && characterPart.Trim().Length != 2)
                return false;

            return true;
        }
    }
}