using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective3
{
    public static class Listing_1_64
    {
        public static void RunMain()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int index = 0; index < values.Length; index++)
            {
                Console.Write(values[index]);
            }
            // Displays
            // 123456
        }
    }
}
