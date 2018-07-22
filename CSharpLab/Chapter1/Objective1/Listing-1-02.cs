using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_02
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("BACKGROUND Thread proc : {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void RunMain()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = true;
            t.Start();
            //t.Join();
        }
    }
}
