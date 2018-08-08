using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective3
{
    public static class Listing_1_60
    {
        public static void RunMain()
        {
            Console.WriteLine(GetValue(true));
            Console.WriteLine(GetValue(false));
        }

        private static int GetValue(bool p)
        {
            if (p)
                return 1;
            else
                return 0;
        }

        private static int GetValue2(bool p)
        {           
            return p ? 1 : 0;
        }
    }
}
