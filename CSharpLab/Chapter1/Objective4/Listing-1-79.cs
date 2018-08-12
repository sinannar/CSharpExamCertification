using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpLab.Chapter1.Objective4
{
    public class Listing_1_79
    {
        public delegate int Calculate(int x, int y);  
        
        public static void RunMain()
        {
            Calculate calc = (x, y) => x + y;
            Console.WriteLine(calc(3, 4));
            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4));
        }
    }
}
