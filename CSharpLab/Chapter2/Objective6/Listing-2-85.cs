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
    public static class Listing_2_85
    {
        static WeakReference data;

        public static void RunMain()
        {            
        }

        public static void Run()
        {
            object result = GetData();
            GC.Collect(); // Uncommneting this line will make data.Target null
            result = GetData();
        }

        private static object GetData()
        {
            if (data == null)
            {
                data = new WeakReference(LoadLargeList());
            }

            if (data.Target == null)
            {
                data.Target = LoadLargeList();
            }

            return data.Target;
        }

        private static object LoadLargeList()
        {
            // Some implementation here

            return null;
        }
    }
}


