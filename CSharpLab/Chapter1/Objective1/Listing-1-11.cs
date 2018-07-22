using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_11
    {
        public static void RunMain()
        {
            Task<int> t = Task.Run(() =>
            {
                Console.WriteLine("Task1 run : " + Thread.CurrentThread.ManagedThreadId);
                //throw new Exception(); //OnlyOnFaulted
                
                return 42;
            });

            t.ContinueWith((i) =>
            {
                Console.WriteLine("OnlyOnCanceled : " + Thread.CurrentThread.ManagedThreadId);
                return i.Result * 2;
            }, TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith((i) =>
            {
                Console.WriteLine("OnlyOnFaulted : " + Thread.CurrentThread.ManagedThreadId);
                return i.Result * 2;
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = t.ContinueWith((i) =>
            {
                Console.WriteLine("OnlyOnRanToCompletion : " + Thread.CurrentThread.ManagedThreadId);
                return i.Result * 2;
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();
        }
    }
}
