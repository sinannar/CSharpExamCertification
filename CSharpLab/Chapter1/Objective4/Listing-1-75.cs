using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective4
{
    public class Listing_1_75
    {
        public static void RunMain()
        {
            var e = new DelegateExample();

            e.UseDelegate();
            DelegateStaticExample.UseDelegate();
        }
    }

    public class DelegateStaticExample
    {
        public delegate int CalculateStatic(int x, int y);  // not need to use 'static' keyword to let delegate point to static function

        public static int Add(int x, int y) { return x + y; }
        public static int Multiply(int x, int y) { return x + y; }

        public static void UseDelegate()
        {
            CalculateStatic calc = Add;
            Console.WriteLine(calc(3, 4));

            calc = Multiply;
            Console.WriteLine(calc(3, 4));
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
