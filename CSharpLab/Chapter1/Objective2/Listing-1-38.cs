using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective2
{
    public static class Listing_1_38
    {
        public static void RunMain()
        {
            WrongLockImplementation1();
            //WrongLockImplementation2();
            CorrectLockImplementation();

        }

        private static void CorrectLockImplementation()
        {
            object gate = new object();
            bool __locakTakenA = false;
            bool __locakTakenB = false;
            int n = 0;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    try
                    {
                        Monitor.Enter(gate, ref __locakTakenA);
                        n++;
                    }
                    finally
                    {
                        if (__locakTakenA)
                        {
                            __locakTakenA = false;
                            Monitor.Exit(gate);
                        }
                    }
                }
            });

            for (int i = 0; i < 1000000; i++)
            {
                try
                {
                    Monitor.Enter(gate, ref __locakTakenB);
                    n--;
                }
                finally
                {
                    if (__locakTakenB)
                    {
                        __locakTakenB = false;
                        Monitor.Exit(gate);
                    }
                }
            }

            up.Wait();
            Console.WriteLine("CorrectLockImplementation result : " + n);
        }

        private static void WrongLockImplementation1()
        {
            object gateA = new object();
            object gateB = new object();
            bool __locakTakenA = false;
            bool __locakTakenB = false;
            int n = 0;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    try
                    {
                        Monitor.Enter(gateA, ref __locakTakenA);
                        n++;
                    }
                    finally
                    {
                        if (__locakTakenA)
                        {
                            __locakTakenA = false;
                            Monitor.Exit(gateA);
                        }
                    }
                }
            });

            for (int i = 0; i < 1000000; i++)
            {
                try
                {
                    Monitor.Enter(gateB, ref __locakTakenB);
                    n--;
                }
                finally
                {
                    if (__locakTakenB)
                    {
                        __locakTakenB = false;
                        Monitor.Exit(gateB);
                    }
                }
            }

            up.Wait();
            Console.WriteLine("WrongLockImplementation1 result : " + n);
        }

        private static void WrongLockImplementation2()
        {
            object gateA = new object();
            bool __locakTakenA = false;
            int n = 0;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    try
                    {
                        Monitor.Enter(gateA, ref __locakTakenA);
                        n++;
                    }
                    finally
                    {
                        if (__locakTakenA)
                        {
                            __locakTakenA = false;
                            Monitor.Exit(gateA);
                        }
                    }
                }
            });

            for (int i = 0; i < 1000000; i++)
            {
                try
                {
                    Monitor.Enter(gateA, ref __locakTakenA);
                    n--;
                }
                finally
                {
                    if (__locakTakenA)
                    {
                        __locakTakenA = false;
                        Monitor.Exit(gateA);
                    }
                }
            }

            up.Wait();
            Console.WriteLine("WrongLockImplementation1 result : " + n);
        }
    }
}
