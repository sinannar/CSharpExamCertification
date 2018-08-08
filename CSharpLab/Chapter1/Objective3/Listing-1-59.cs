using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective3
{
    public static class Listing_1_59
    {
        public static void RunMain()
        {
            int? x = null;
            int? z = null;
            int y = x ??
                    z ??
                    -1;

            Console.WriteLine(y);
        }
    }
}
