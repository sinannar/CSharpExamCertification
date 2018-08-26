using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace CSharpLab.Chapter2.Objective3
{
    public static class Listing_2_34
    {
        public static void RunMain()
        {

        }

        public class Base
        {
            private int _privateField = 42;
            protected int _protectedField = 42;
            private void MyPrivateMethod() { }
            protected void MyProtectedMethod() { }
        }
        public class Derived : Base
        {
            public void MyDerivedMethod()
            {
                // _privateField = 41;  // Not OK, this will generate a compile error
                _protectedField = 43;   // OK, protected fields can be accessed
                //MyPrivateMethod();    // MyPrivateMethod(); // Not OK, this will generate a compile error
                MyProtectedMethod();    // OK, protected methods can be accessed
            }
        }
    }
}
