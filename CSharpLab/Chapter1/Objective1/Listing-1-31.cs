using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_31
    {
        public static void RunMain()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            Task.Run(() => {
                bag.Add(42);
                bag.Add(42);
                bag.Add(42);
                bag.Add(42);
                bag.Add(42);
                bag.Add(42);
                Thread.Sleep(1000);
                bag.Add(21);
            });

            Task.Run(() =>
            {
                Thread.Sleep(100);
                foreach (int item in bag)
                {
                    Console.WriteLine(item);
                }
            }).Wait() ;

        }
    }
}
