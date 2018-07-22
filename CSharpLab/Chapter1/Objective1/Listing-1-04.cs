using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_04
    {
        public static bool stopped = false;

        public static void ThreadMethod()
        {
            int a = 0;
            while (!stopped)
            {
                Console.WriteLine("Thread proc" + (a++) + " => " + stopped);
                Thread.Sleep(0);
            }
        }

        public static void RunMain()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            while (!stopped)
            {
                var a = Console.ReadKey(true);
                switch (a.Key)
                {
                    case ConsoleKey.A:
                        { stopped = true; }
                        break;
                }
            }

            t.Join();
        }
    }
}
