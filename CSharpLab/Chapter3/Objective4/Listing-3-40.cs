using System;
using System.Reflection;

namespace CSharpLab.Chapter3.Objective4
{
    public static class Listing_3_40
    {
        public static void RunMain()
        {
#pragma warning disable 0162, 0168
            int i;
#pragma warning restore 0162
            while (false)
            {
                Console.WriteLine("Unreachable code");
            }
#pragma warning restore 
        }

    }
}
