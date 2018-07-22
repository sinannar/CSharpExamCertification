using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_10
    {
        public static void RunMain()
        {
            Task<int> t = Task.Run(() =>
            {
                Console.WriteLine("Task1 run : " + Thread.CurrentThread.ManagedThreadId);
                return 42;
            }).ContinueWith((i) =>
            {
                Console.WriteLine("Continuation Task 1 run : " + Thread.CurrentThread.ManagedThreadId);
                return i.Result * 2;
            }).ContinueWith((i) =>
            {
                Console.WriteLine("Continuation Task 2 run : " + Thread.CurrentThread.ManagedThreadId);
                return i.Result * 2;
            }).ContinueWith((i) =>
            {
                Console.WriteLine("Continuation Task 3 run : " + Thread.CurrentThread.ManagedThreadId);
                return i.Result * 2;
            }).ContinueWith((i) =>
            {
                Console.WriteLine("Continuation Task 4 run : " + Thread.CurrentThread.ManagedThreadId);
                return i.Result * 2;
            }).ContinueWith((i) =>
            {
                Console.WriteLine("Continuation Task 5 run : " + Thread.CurrentThread.ManagedThreadId);
                return i.Result * 2;
            });

            Console.WriteLine(t.Result + " : MAIN : " + Thread.CurrentThread.ManagedThreadId);

        }
    }
}
