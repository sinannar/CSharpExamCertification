using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective2
{
    public static class Listing_1_44
    {
        public static void RunMain()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() => {
                while(!token.IsCancellationRequested)
                {
                    Console.WriteLine("*");
                    Thread.Sleep(1000);
                }

                token.ThrowIfCancellationRequested();
            }, token).ContinueWith((t) => {

                t.Exception.Handle((e) => true);
                Console.WriteLine("You have canceled the task");
            }, TaskContinuationOptions.OnlyOnCanceled);


            try
            {
                Console.Write("Press enter to stop the task");
                Console.ReadKey();
                cancellationTokenSource.Cancel();
                task.Wait();
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.InnerExceptions[0].Message);
            }
            Console.WriteLine("Press enter to end the application");
            Console.ReadKey();

        }
    }
}
