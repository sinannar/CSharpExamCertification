using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_14
    {       
        public static void RunMain()
        {
            Task[] tasks = new Task[3];

            tasks[0] = Task.Run(() => {
                Thread.Sleep(100);
                Console.WriteLine("1");
                return 1;
            });
            tasks[1] = Task.Run(() => {
                Thread.Sleep(100);
                Console.WriteLine("2");
                return 2;
            });
            tasks[2] = Task.Run(() => {
                Thread.Sleep(100);
                Console.WriteLine("3");
                return 3;
            });
            Task.WaitAll(tasks);
        }
    }
}
