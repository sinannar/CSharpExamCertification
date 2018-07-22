using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_01
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine("Thread proc : {0}", i);
                //Thread.Sleep(0);
                Thread.Yield();
            }
        }

        public static void RunMain()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            Thread t2 = new Thread(new ThreadStart(ThreadMethod));
            t.Start();
            t2.Start();

            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine("Main thread : {0}", i);
                //Thread.Sleep(0);
                Thread.Yield();
            }

            //Console.WriteLine("DONE");
            t.Join();
            t2.Join();
        }
    }
}
