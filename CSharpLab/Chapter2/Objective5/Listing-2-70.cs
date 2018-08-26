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

namespace CSharpLab.Chapter2.Objective5
{
    public static class Listing_2_70
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

        public class MyPlugin : IPlugin
        {
            public string Name
            {
                get { return "MyPlugin"; }
            }

            public string Description
            {
                get { return "My Sample Plugin"; }
            }

            public bool Load(Program application)
            {
                return true;
            }
        }

    }
}

