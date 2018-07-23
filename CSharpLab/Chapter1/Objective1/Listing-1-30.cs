using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_30
    {
        public static void RunMain()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            bag.Add(21);
            bag.Add(22);

            int result;

            if (bag.TryTake(out result))
            {
                Console.WriteLine(result);
            }
            if (bag.TryTake(out result))
            {
                Console.WriteLine("next item is  {0}", result);
            }
            if (bag.TryTake(out result))
            {
                Console.WriteLine("3rd item is  {0}", result);
            }
            else
            {
                Console.WriteLine("failed taking 3rd item");
            }
        }
    }
}
