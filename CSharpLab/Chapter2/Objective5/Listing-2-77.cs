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
    public static class Listing_2_77
    {
        public static void RunMain()
        {
            Func<int, int, int> addFunc = (x, y) => x + y;
            Console.WriteLine(string.Format("2 + 3 = {0}", addFunc(2, 3)));

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}

