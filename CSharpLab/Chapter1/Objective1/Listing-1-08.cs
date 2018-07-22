using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_08
    {
        public static void RunMain()
        {
            Task t1 = Task.Run(() => {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("*1 = " + i);
                }
            });

            Task t2 = Task.Run(() => {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("*2 = " + i);
                }
            });

            Task t3 = Task.Run(() => {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("*3 = " + i);
                }
            });
            t1.Wait();
            t2.Wait();
            t3.Wait();
        }
    }
}
