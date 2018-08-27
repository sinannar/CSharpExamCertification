using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Data.Entity;

namespace CSharpLab.Chapter3.Objective1
{
    public static class Listing_3_05
    {
        public static void RunMain()
        {
            string value = "1";
            int result;

            bool success = int.TryParse(value, out result);

            if (success)
            {
                Console.WriteLine("succeeded");
            }
            else
            {
                Console.WriteLine("not succeeded");
            }
        }
    }
}
