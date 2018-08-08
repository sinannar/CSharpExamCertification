using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective3
{
    public static class Listing_1_73
    {
        public static void RunMain()
        {
            var people = new List<Person>
            {
                new Person(){FirstName="John",LastName="Doe"},
                new Person(){FirstName="John",LastName="Doe"},
            };

            List<Person>.Enumerator e = people.GetEnumerator();
            try
            {
                Person v;
                while (e.MoveNext())
                {
                    v = e.Current;
                }
            }
            finally
            {
                System.IDisposable d = e as System.IDisposable;
                if (d != null) d.Dispose();
            }

        }

        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
