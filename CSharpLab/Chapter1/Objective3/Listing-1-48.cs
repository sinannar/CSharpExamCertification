using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective3
{
    public static class Listing_1_48
    {
        public static void RunMain()
        {
            OrShortCircuit();
        }

        public static void OrShortCircuit()
        {
            Console.WriteLine("OrShortCircuit start");
            bool x = true;
            bool result = x || GetY();
            Console.WriteLine("OrShortCircuit finish");
        }

        private static bool GetY()
        {
            Console.WriteLine("This method doesn’t get called");
            return true;
        }
    }
}
