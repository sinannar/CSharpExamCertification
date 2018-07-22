using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_05
    {
        [ThreadStatic]
        public static int _field;

        public static void RunMain()
        {
            new Thread(() => {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread A " + _field);
                }
            }).Start();
            new Thread(() => {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread B " + _field);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
