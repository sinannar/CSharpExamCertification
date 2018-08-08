using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective3
{
    public static class Listing_1_57
    {
        public static void RunMain()
        {
            bool x = false;
            bool y = false;
            if (x)
            {
                if (y)
                {
                    F();
                }
                else
                {
                    G();
                }
            }
        }

        private static void G()
        {
            Console.WriteLine("G CALLED");
        }

        private static void F()
        {
            Console.WriteLine("F CALLED");
        }
    }
}
