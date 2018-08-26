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
    public static class Listing_2_33
    {
        public static void RunMain()
        {

        }

        public class Accessibility
        {
            // initialization code and error checking omitted
            private string[] _myField;
            public string MyProperty
            {
                get { return _myField[0]; }
                set { _myField[0] = value; }
            }
        }
    }
}
