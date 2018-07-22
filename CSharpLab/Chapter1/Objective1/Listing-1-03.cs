using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_03
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o ; i++)
            {
                Console.WriteLine("Thread proc : {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void RunMain()
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(5);
            t.Join();
        }
    }
}
