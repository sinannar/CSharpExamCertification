using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace CSharpLab.Chapter2.Objective4
{
    public static class Listing_2_49
    {
        public static void RunMain()
        {
            
        }

        abstract class Base
        {
            public virtual void MethodWithImplementation() { /* Method with implementation */ }

            public abstract void AbstractMethod();
        }

        class Derived : Base
        {
            public override void AbstractMethod() { }
        }
    }
}
