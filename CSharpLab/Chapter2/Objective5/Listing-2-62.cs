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
    public static class Listing_2_62
    {

        public static void RunMain()
        {
            ConditionalAttribute conditionalAttribute = 
                (ConditionalAttribute)Attribute.GetCustomAttribute(typeof(ConditionalClass), typeof(ConditionalAttribute));
            string condition = conditionalAttribute.ConditionString; // returns CONDITION1 // not throw error, will figure it out soon
        }

        class ConditionalClass
        {
            [Conditional("CONDITION1"), Conditional("CONDITION2")]
            static void MyMethod() { }
        }


    }
}
