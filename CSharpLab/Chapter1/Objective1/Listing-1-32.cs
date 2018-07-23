using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_32
    {
        public static void RunMain()
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();

            stack.Push(42);

            int result;

            if(stack.TryPop(out result))
            {
                Console.WriteLine("popped {0}", result);
            }

            stack.PushRange(new int[] { 1,2,3});
            int[] values = new int[2];

            stack.TryPopRange(values);

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

        }
    }
}
