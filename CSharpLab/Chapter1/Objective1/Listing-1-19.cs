using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_19
    {
        public static void RunMain()
        {
            Task.Run(() =>
            {
                Console.WriteLine("SleepAsyncA Start");
                SleepAsyncA(3000).ConfigureAwait(false);
                Console.WriteLine("SleepAsyncA Finish");
                Console.WriteLine("SleepAsyncB Start");
                SleepAsyncB(2000).ConfigureAwait(false);
                Console.WriteLine("SleepAsyncB Finish");
            });
        }

        public static async Task SleepAsyncA(int millisecondsTimeout)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("INSIDE SleepAsyncA Start");
                Thread.Sleep(millisecondsTimeout);
                Console.WriteLine("INSIDESleepAsyncA Finish");
                return true;
            });
        }

        public static async Task SleepAsyncB(int millisecondsTimeout)
        {
            Console.WriteLine("INSIDE SleepAsyncB Start");
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(millisecondsTimeout, -1);
            await tcs.Task;
            Console.WriteLine("SleepAsyncB Finish");
        }
    }
}
