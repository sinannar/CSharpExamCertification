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


namespace CSharpLab.Chapter2.Objective5
{
    public static class Listing_2_78
    {
        public static void RunMain()
        {
            BlockExpression blockExpression = Expression.Block(
                Expression.Call(
                    null, 
                    typeof(Console).GetMethod(
                        "Write", 
                        new Type[] { typeof(string) }),
                    Expression.Constant("Hello ")),
                Expression.Call(
                    null, 
                    typeof(Console).GetMethod(
                        "WriteLine", 
                        new Type[] { typeof(string) }),
                    Expression.Constant("World"))
                );

            var action = Expression.Lambda<Action>(blockExpression).Compile();
            Console.WriteLine("BEFORE CALL");
            action();
            Console.WriteLine("AFTER CALL");

            Console.ReadKey();
        }
    }
}

