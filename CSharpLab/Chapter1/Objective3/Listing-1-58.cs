using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective3
{
    public static class Listing_1_58
    {
        public static void RunMain()
        {
            int? x = null;
            int y = x ?? -1;

            Console.WriteLine(y);
        }
    }
}
