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
    public static class Listing_2_36
    {
        public static void RunMain()
        {

        }

        public class MyClass
        {
            private int _field;

            public void SetValue(int value) { _field = value; }

            public int GetValue() { return _field; }
        }
    }
}
