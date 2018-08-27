using System;
using System.Diagnostics;
using System.Reflection;

namespace CSharpLab.Chapter3.Objective4
{
    public static class Listing_3_42
    {
        public static void RunMain()
        {
            SomeMethod();
        }

        public static void SomeMethod()
        {
            Log("Step1");
        }

        /*         
            #if DEBUG
                Log(“Step1”);
            #endif   
        */
        [Conditional("DEBUG")]
        private static void Log(string message)
        {
            Console.WriteLine(message);
        }

    }
}
