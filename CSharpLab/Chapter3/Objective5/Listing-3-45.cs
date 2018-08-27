using System;
using System.Diagnostics;
using System.Reflection;

namespace CSharpLab.Chapter3.Objective5
{
    public static class Listing_3_45
    {
        public static void RunMain()
        {
            Debug.WriteLine("Starting application");
            Debug.Indent();
            int i = 1 + 2;
            Debug.Assert(i == 3);
            Debug.WriteLineIf(i > 0, "i is greated than 0");

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}

