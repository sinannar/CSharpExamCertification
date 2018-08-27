using System;
using System.Reflection;

namespace CSharpLab.Chapter3.Objective4
{
    public static class Listing_3_39
    {
        public static void RunMain()
        {
#pragma warning disable
            while (false)
            {
                Console.WriteLine("Unreachable code");
            }
#pragma warning restore
        }

    }
}
