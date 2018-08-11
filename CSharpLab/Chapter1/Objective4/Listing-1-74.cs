using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective4
{
    public class Listing_1_74
    {
        public static void RunMain()
        {
            var e = new DelegateExample();

            e.UseDelegate();
        }
    }

    public class DelegateExample
    {
        public delegate int Calculate(int x, int y);

        public int Add(int x, int y) { return x + y; }
        public int Multiply(int x, int y) { return x + y; }

        public void UseDelegate()
        {
            Calculate calc = Add;
            Console.WriteLine(calc(3, 4));

            calc = Multiply;
            Console.WriteLine(calc(3, 4));
        }
    }
}
