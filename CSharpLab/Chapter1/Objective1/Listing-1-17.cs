using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_17
    {
        public static void RunMain()
        {
            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState state) =>
            {
                Console.WriteLine("loop at {0}",i);
                if (i == 500)
                {
                    Console.WriteLine("breaking loop");
                    state.Break();
                }
            });

            Console.ReadKey();

            ParallelLoopResult result2 = Parallel.For(0, 1000, (int i, ParallelLoopState state) =>
            {
                Console.WriteLine("loop at {0}", i);
                if (i == 500)
                {
                    Console.WriteLine("breaking loop");
                    state.Stop();
                }
            });
        }
    }
}
