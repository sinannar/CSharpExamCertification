using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_12
    {
        public static void RunMain()
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];
                Console.WriteLine("PARENT : " + Thread.CurrentThread.ManagedThreadId);

                new Task(() =>
                {
                    //Thread.Sleep(100);
                    Console.WriteLine("0 : " + Thread.CurrentThread.ManagedThreadId);
                    results[0] = 0;
                }, TaskCreationOptions.AttachedToParent).Start();

                new Task(() =>
                {
                    //Thread.Sleep(100);
                    Console.WriteLine("1 : " + Thread.CurrentThread.ManagedThreadId);
                    results[1] = 1;
                }, TaskCreationOptions.AttachedToParent).Start();

                new Task(() =>
                {
                    //Thread.Sleep(100);
                    Console.WriteLine("2 : " + Thread.CurrentThread.ManagedThreadId);
                    results[2] = 2;
                }, TaskCreationOptions.AttachedToParent).Start();


                return results;
            });

            var finalTask = parent.ContinueWith(parentTask =>
            {
                Console.WriteLine("CONT TASK : " + Thread.CurrentThread.ManagedThreadId);
                foreach (var i in parentTask.Result)
                {
                    Console.WriteLine(i);
                }
            });

            finalTask.Wait();//if you dont put this one, you may access array without assigned variables so you may end up seeing 0,0,0
        }
    }
}
