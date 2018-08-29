﻿


using System;
using System.Collections.Generic;

namespace Chapter4.Obj5
{
    public static class Listing_4_087
    {
        public static void RunMain()
        {
            HashSet<int> oddSet = new HashSet<int>();
            HashSet<int> evenSet = new HashSet<int>();

            for (int x = 1; x <= 10; x++)
            {
                if (x % 2 == 0)
                {
                    evenSet.Add(x);
                }
                else
                {
                    oddSet.Add(x);
                }
            }

            Console.WriteLine("Odd set:");
            DisplaySet(oddSet);
            Console.WriteLine("Even set:");
            DisplaySet(evenSet);

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }

        private static void DisplaySet(HashSet<int> set)
        {
            Console.Write("{");
            foreach (int i in set)
            {
                Console.Write(" {0}", i);
            }

            Console.WriteLine(" }");
        }
    }
}
