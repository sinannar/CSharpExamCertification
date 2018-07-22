using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_16
    {
        public static void RunMain()
        {
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine("Parallel.For : " + i);
                //Thread.Sleep(100);
            });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
            {
                Console.WriteLine("Parallel.ForEach : " + i);
                //Thread.Sleep(100);
            });
        }
    }
}
