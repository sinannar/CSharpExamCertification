﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_34
    {
        public static void RunMain()
        {
            ConcurrentDictionary<string, int> dict = new ConcurrentDictionary<string, int>();

            if (dict.TryAdd("k1", 42)) {
                Console.WriteLine("added");
            }

            if(dict.TryUpdate("k1",21,42))
            {
                Console.WriteLine("42 replaced with 21");
            }

            dict["k1"] = 42; //overwrite unconditionally

            int r1 = dict.AddOrUpdate("k1",3,(s,i) => i*2);
            int r3 = dict.AddOrUpdate("k3",3, foo);
            int r2 = dict.GetOrAdd("k2",3);

            Console.WriteLine($"r1 {r1}");
            Console.WriteLine($"r3 {r3}");
            Console.WriteLine($"r2 {r2}");

        }

        private static int foo(string s, int i)
        {
            Console.WriteLine($"s:{s} i:{i}");
            return i * 2;
        }
    }
}
