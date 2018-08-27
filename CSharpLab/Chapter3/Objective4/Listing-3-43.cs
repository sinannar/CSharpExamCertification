using System;
using System.Diagnostics;
using System.Reflection;

namespace CSharpLab.Chapter3.Objective4
{
    public static class Listing_3_43
    {
        public static void RunMain()
        {
            var v = new Person
            {
                FirstName = "a",
                LastName = "b"
            };

        }

        [DebuggerDisplay("Name = {FirstName} {LastName}")]
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

    }
}

