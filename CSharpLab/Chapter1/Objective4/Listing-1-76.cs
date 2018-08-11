using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective4
{
    public class Listing_1_76
    {
        public static void MethodOne()
        {
            Console.WriteLine("method one");
        }

        public static void MethodTwo()
        {
            Console.WriteLine("method two");
        }

        public delegate void Del();

        public static void RunMain()
        {
            Del d = MethodOne;
            d += MethodTwo;

            d();

            int invoactionCount = d.GetInvocationList().GetLength(0);
            Console.WriteLine($" invoactionCount : {invoactionCount}");
        }
    }
}
