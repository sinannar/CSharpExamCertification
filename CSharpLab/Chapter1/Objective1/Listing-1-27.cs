using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_27
    {
        public static void RunMain()
        {
            var numbers = Enumerable.Range(0, 20);

            try
            {
                var parallelResult = numbers.AsParallel()
                    .Where(i => IsEven(i));

                parallelResult.ForAll(e => Console.WriteLine(e));
            }
            catch (AggregateException e)
            {
                Console.WriteLine("There were {0} exceptions",e.InnerExceptions.Count);
            }

            var parallelArray = numbers.AsParallel()
                .Where(i => i % 2 == 0);

            parallelArray.ForAll(e => Console.WriteLine(e));
        }

        public static bool IsEven(int i)
        {
            if (i % 10 == 0) throw new ArgumentException($"{i}");
            return i % 2 == 0;
        }
    }
}
