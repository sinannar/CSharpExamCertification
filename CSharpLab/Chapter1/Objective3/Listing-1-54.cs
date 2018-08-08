using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective3
{
    public static class Listing_1_54
    {
        public static void RunMain()
        {
            bool b = true;
            if (b)
            {
                int r = 42;
                b = false;
            }
            // r is not accessible
            // b is now false
        }
    }
}
