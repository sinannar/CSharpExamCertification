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
    public static class Listing_2_66
    {

        public static void RunMain()
        {
           
        }

        [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
        public class MyMethodAndParameterAttribute : Attribute
        { }


        [MyMethodAndParameter]
        class MyClass
        {
            [MyMethodAndParameter]
            void MyMethod()
            { }
        }
    }


}
