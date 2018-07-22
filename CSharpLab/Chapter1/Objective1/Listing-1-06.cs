using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_06
    {
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() => {

            ThreadPriority Priority = Thread.CurrentThread.Priority;
            string Name = Thread.CurrentThread.Name;
            var IsBackground = Thread.CurrentThread.IsBackground;
            var IsAlive = Thread.CurrentThread.IsAlive;
            var IsThreadPoolThread = Thread.CurrentThread.IsThreadPoolThread;
            ThreadState ThreadState = Thread.CurrentThread.ThreadState;
            //ApartmentState ApartmentState = Thread.CurrentThread.ApartmentState;
            CultureInfo CurrentCulture = Thread.CurrentThread.CurrentCulture;
            CultureInfo CurrentUICulture = Thread.CurrentThread.CurrentUICulture;
            ExecutionContext ExecutionContext = Thread.CurrentThread.ExecutionContext;

            return Thread.CurrentThread.ManagedThreadId;
        });

        public static void RunMain()
        {
            new Thread(() => {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread A:{0} {1}",_field.Value, i);
                }
            }).Start();
            new Thread(() => {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread B:{0} {1}", _field.Value, i);
                }
            }).Start();

            for (int i = 0; i < _field.Value; i++)
            {
                Console.WriteLine("Thread Main:{0} {1}", _field.Value, i);
            }
        }
    }
}
