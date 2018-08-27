using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Data.Entity;
using System.Globalization;

namespace CSharpLab.Chapter3.Objective1
{
    public static class Listing_3_06
    {
        public static void RunMain()
        {
            CultureInfo english = new CultureInfo("En");
            CultureInfo dutch = new CultureInfo("Nl");

            string value = "€19,95";
            decimal d = decimal.Parse(value, NumberStyles.Currency, dutch);
            Console.WriteLine(d.ToString(english)); // Displays 19.95            Console.WriteLine(d.ToString(dutch)); // Displays 19.95
        }
    }
}
