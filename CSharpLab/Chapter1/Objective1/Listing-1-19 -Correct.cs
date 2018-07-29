using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_19_Correct
    {
        public static void RunMain()
        {
            SleepAsyncA(3000);
            SleepAsyncB(2000);
        }

        public static Task SleepAsyncA(int millisecondsTimeout)
        {
            return Task.Run(() => {
                Console.WriteLine("SleepAsyncA Start");
                Thread.Sleep(millisecondsTimeout);
                Console.WriteLine("SleepAsyncA Finish");
            });
        }

        public static Task SleepAsyncB(int millisecondsTimeout)
        {
            Console.WriteLine("SleepAsyncB Start");
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(millisecondsTimeout, -1);
            Console.WriteLine("SleepAsyncB Finish");
            return tcs.Task;
        }
    }
}
