using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Reflection;


namespace CSharpLab.Chapter2.Objective6
{
    public static class Listing_2_79
    {
        public static void RunMain()
        {
            for (int i = 0; i < 15; i++)
            {
                var v = new SomeType();
                GC.Collect();
            }
            Console.ReadKey();
        }

        class SomeType
        {
            // Constructor
            public SomeType()
            {
                Console.WriteLine("Constructor");
            }

            // Finalizer (destructor)
            ~SomeType()
            {
                Console.WriteLine("Destructor");
            }
        }
    }
}


