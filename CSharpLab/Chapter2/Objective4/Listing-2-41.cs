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
    public static class Listing_2_41
    {
        public static void RunMain()
        {

        }

        interface IExample
        {
            string GetResult();

            int Value { get; set; }

            event EventHandler ResultRetrieved;

            int this[string index] { get; set; }
        }

        class ExampleImplementation : IExample
        {
            public string GetResult()
            {
                return "result";
            }

            //private int Value { get; set; } // has to be public

            public int Value { get; set; }

            public event EventHandler CalculationPerformed;

            public event EventHandler ResultRetrieved;

            public int this[string index]
            {
                get
                {
                    return 42;
                }
                set { }
            }
        }
    }
}
