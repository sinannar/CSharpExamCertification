using System;

namespace CSharpLab.Chapter2.Objective1
{
    public static class Listing_2_08
    {
        public static void RunMain()
        {

        }

        public class A
        {
            public void MethodWithoutAnyReturnValue()
            { /* Don’t return any value to the caller */ }

            public int MethodWithReturnValue()
            {
                return 42;
            }
        }
    }
}
