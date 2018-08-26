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
    public static class Listing_2_81
    {
        public static void RunMain()
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("Some data");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            File.Delete("temp.dat"); // Throws an IOException because the file is already open.
        }
    }
}


