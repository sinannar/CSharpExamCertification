using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;

namespace CSharpLab.Chapter2.Objective5
{
    public static class Listing_2_73
    {
        public static void RunMain()
        {
            int i = 42;
            MethodInfo compareToMethod = i.GetType().GetMethod("CompareTo", new Type[] { typeof(int) });
            int result = (int)compareToMethod.Invoke(i, new object[] { 41 });

            Console.WriteLine("42 CompareTo 41 (expected value 1):");
            Console.WriteLine(result);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }        
    }
}

