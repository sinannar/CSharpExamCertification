﻿using System;
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
    public static class Listing_3_34
    {
        public static void RunMain()
        {
            DebugDirective();
            Console.ReadKey();
        }

        public static void DebugDirective()
        {
#if DEBUG
            Console.WriteLine("Debug mode");
#else
        Console.WriteLine("Not debug");
#endif
        }
    }
}