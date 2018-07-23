using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_23
    {
        public static void RunMain()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelArray = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach (var i in parallelArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
