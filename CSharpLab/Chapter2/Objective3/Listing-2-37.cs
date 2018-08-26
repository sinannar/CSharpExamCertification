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
    public static class Listing_2_37
    {
        public static void RunMain()
        {

        }

        class Person
        {
            public int Value { get; set; }

            private string _firstName;

            public string FirstName
            {
                get { return this._firstName; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException();
                    }

                    this._firstName = value;
                }
            }
        }
    }
}
