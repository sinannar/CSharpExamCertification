using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Data.Entity;
using System.Globalization;

namespace CSharpLab.Chapter3.Objective1
{
    public static class Listing_3_08
    {
        public static void RunMain()
        {
            double d = 23.15;
            int i = Convert.ToInt32(d);
            Console.WriteLine(i);
        }
    }
}
