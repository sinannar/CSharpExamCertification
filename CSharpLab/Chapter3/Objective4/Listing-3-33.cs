using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Data.Entity;
using System.Globalization;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Security;
using System.Runtime.InteropServices;
using System.Threading;

namespace CSharpLab.Chapter3.Objective4
{
    public static class Listing_3_33
    {
        public static void RunMain()
        {
            Timer t = new Timer(TimerCallback, null, 0, 100);
            Console.ReadKey();
        }

        private static void TimerCallback(Object o)
        {
            Console.WriteLine("In TimerCallback: " + DateTime.Now);
            GC.Collect();
        }
    }
}
