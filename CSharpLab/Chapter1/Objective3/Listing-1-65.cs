using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective3
{
    public static class Listing_1_65
    {
        public static void RunMain()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int x = 0, y = values.Length - 1;
            ((x < values.Length) && (y >= 0));
            x++, y--)
            {
                Console.Write(values[x]);
                Console.Write(values[y]);
            }
            // Displays
            // 162534435261
        }
    }
}
