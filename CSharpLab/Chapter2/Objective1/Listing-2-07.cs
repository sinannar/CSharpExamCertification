using System;

namespace CSharpLab.Chapter2.Objective1
{
    public static class Listing_2_07
    {
        public static void RunMain()
        {

        }

        public class A
        {
            private void MyMethod(int firstArgument, string secondArgument = "default value", bool thirdArgument = false)
            {

            }

            private void CallingMethod()
            {
                MyMethod(1, thirdArgument: true);
            }
        }
    }
}
