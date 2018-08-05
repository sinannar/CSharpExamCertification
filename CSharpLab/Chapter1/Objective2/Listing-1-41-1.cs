using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/volatile

namespace CSharpLab.Chapter1.Objective2
{
    public static class Listing_1_41_1
    {
        static int value = 1;

        public static void RunMain()
        {
            Task t1 = Task.Run(() => {
                Interlocked.CompareExchange(ref value, 2, 1);
            });

            Task t2 = Task.Run(() => {
                Interlocked.CompareExchange(ref value, 3, 1);
            });

            Task.WaitAll(t1,t2);
            Console.WriteLine(value);
        }
    }
}


/*        
public static int Add(ref int location1, int value);   
public static long Add(ref long location1, long value);       
public static double CompareExchange(ref double location1, double value, double comparand);        
public static int CompareExchange(ref int location1, int value, int comparand);
public static long CompareExchange(ref long location1, long value, long comparand);
public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand);
public static object CompareExchange(ref object location1, object value, object comparand);
public static float CompareExchange(ref float location1, float value, float comparand);
public static T CompareExchange<T>(ref T location1, T value, T comparand) where T : class;
public static int Decrement(ref int location);
public static long Decrement(ref long location);
public static T Exchange<T>(ref T location1, T value) where T : class;
public static float Exchange(ref float location1, float value);
public static object Exchange(ref object location1, object value);
public static double Exchange(ref double location1, double value);
public static long Exchange(ref long location1, long value);
public static int Exchange(ref int location1, int value);
public static IntPtr Exchange(ref IntPtr location1, IntPtr value);
public static int Increment(ref int location);
public static long Increment(ref long location);
public static void MemoryBarrier();
public static void MemoryBarrierProcessWide();
public static long Read(ref long location);
*/
