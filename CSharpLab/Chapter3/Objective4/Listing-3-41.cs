using System;
using System.Reflection;

namespace CSharpLab.Chapter3.Objective4
{
    public static class Listing_3_41
    {
        public static void RunMain()
        {

        }

        public static void SomeMethod()
        {
#if DEBUG
            Log("Step1");
#endif
        }

        private static void Log(string message)
        {
            Console.WriteLine(message);
        }

    }
}
