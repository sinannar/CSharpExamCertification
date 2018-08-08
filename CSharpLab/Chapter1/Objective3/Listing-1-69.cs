using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective3
{
    public static class Listing_1_69
    {
        public static void RunMain()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            {
                int index = 0;
                while (index < values.Length)
                {
                    Console.Write(values[index]);
                    index++;
                }
            }
        }
    }
}
