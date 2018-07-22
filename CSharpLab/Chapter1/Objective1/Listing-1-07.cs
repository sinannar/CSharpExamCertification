using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_07
    {
        public static void RunMain()
        {
            ThreadPool.QueueUserWorkItem((s) => {
                Console.WriteLine("Working on a thread from threadpool");
            });

            Console.ReadKey();
        }
    }
}
