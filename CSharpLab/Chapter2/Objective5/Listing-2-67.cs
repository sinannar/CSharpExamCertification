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
    public static class Listing_2_67
    {

        public static void RunMain()
        {
           
        }      

        [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
        class MyMultipleUsageAttribute : Attribute { }

        [MyMultipleUsage, MyMultipleUsage]
        class MyClassWithMultipleAttribute
        { }
    }


}
