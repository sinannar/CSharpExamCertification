using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective2
{
    public static class Listing_1_45
    {
        public static void RunMain()
        {
            Task longRunning = Task.Run(() =>
            {
                Thread.Sleep(10000);
            });

            int index = Task.WaitAny(new[] { longRunning},1000);

            if(index == -1)
            {
                Console.WriteLine("Task timed out");
            }

        }
    }
}
