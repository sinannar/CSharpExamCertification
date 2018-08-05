using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/volatile

namespace CSharpLab.Chapter1.Objective2
{
    public static class Listing_1_39
    {
        private static volatile int _flag = 0;
        private static int _value = 0;


        public static void RunMain()
        {
            Thread t1 = new Thread(new ThreadStart(Thread1));
            Thread t2 = new Thread(new ThreadStart(Thread2));

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
        }

        public static void Thread1()
        {
            _value = 5;
            _flag = 1;
        }

        public static void Thread2()
        {
            if(_flag == 1)
            {
                Console.WriteLine(_value);
            }
        }
    }
}
