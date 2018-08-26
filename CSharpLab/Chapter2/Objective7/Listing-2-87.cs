using System;
using System.Text;

namespace CSharpLab.Chapter2.Objective7
{
    public static class Listing_2_87
    {
        public static void RunMain()
        {
            StringBuilder sb = new StringBuilder("A initial value");
            Console.WriteLine(sb);
            sb[0] = 'B';
            Console.WriteLine(sb);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}


