using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Data.Entity;

namespace CSharpLab.Chapter3.Objective1
{
    public static class Listing_3_04
    {
        public static void RunMain()
        {
            string value = "true";
            bool b = bool.Parse(value);
            Console.WriteLine(b); // displays True
        }
    }
}
