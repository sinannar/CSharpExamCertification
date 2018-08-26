using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace CSharpLab.Chapter2.Objective2
{
    public static class Listing_2_29
    {
        public static void RunMain()
        {
            dynamic obj = new SampleObject();
            Console.WriteLine(obj.SomeProperty);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        public class SampleObject : DynamicObject
        {
            public override bool TryGetMember(GetMemberBinder binder, out object result)
            {
                Console.WriteLine("TryGetMember called");
                result = binder.Name;
                return true;
            }
        }
    }
}
