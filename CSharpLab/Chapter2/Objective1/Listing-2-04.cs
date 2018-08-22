using System;

namespace CSharpLab.Chapter2.Objective1
{
    public static class Listing_2_04
    {
        public static void RunMain()
        {
            Calculator cal = new Calculator();
            Console.WriteLine(cal.Add(1, 2));
        }

        public class Calculator
        {
            public int Add(int x, int y)
            {
                return x + y;
            }
        }
    }
}
