using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective2
{
    public static class Listing_1_35
    {
        public static void RunMain()
        {
            int n = 0;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    n++;
                }
            });

            for (int i = 0; i < 1000000; i++)
            {
                n--;
            }

            up.Wait();
            Console.WriteLine(n);
        }
    }
}
