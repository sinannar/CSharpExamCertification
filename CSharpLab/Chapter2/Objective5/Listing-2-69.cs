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
    public static class Listing_2_69
    {

        public static void RunMain()
        {
           
        }

        public interface IPlugin
        {
            string Name { get; }
            string Description { get; }
            bool Load(Program application);
        }
    }
}