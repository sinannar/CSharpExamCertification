using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_33
    {
        public static void RunMain()
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);

            int result;
            if(queue.TryDequeue(out result))
            {
                Console.WriteLine("Dequeued {0}", result);
            }
        }
    }
}
