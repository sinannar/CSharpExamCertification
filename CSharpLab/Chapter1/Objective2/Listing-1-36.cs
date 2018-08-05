using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective2
{
    public static class Listing_1_36
    {
        public static void RunMain()
        {
            int n = 0;
            object _lock = new object();

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    lock(_lock)
                        n++;
                }
            });

            for (int i = 0; i < 1000000; i++)
            {
                lock(_lock)
                    n--;
            }

            up.Wait();
            Console.WriteLine(n);
        }
    }
}
