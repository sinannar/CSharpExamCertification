using System;
using System.Text;

namespace CSharpLab.Chapter2.Objective7
{
    public static class Listing_2_88
    {
        public static void RunMain()
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            for (int i = 0; i < 10000; i++)
            {
                sb.Append("x");
                sb.Append(1);
            }
            Console.WriteLine(sb);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}


