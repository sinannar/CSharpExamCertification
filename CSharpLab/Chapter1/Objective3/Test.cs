using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective3
{
    public static class Test
    {
        public static void RunMain()
        {
            Person p1 = null;
            Person p2 = new Person { FirstName = "FirstName", LastName = "LastName" };

            string s = p1?.ToString();
            //string s2 = p1 ?? "EmptyString"; //=> this does not work
            Person p3 = p1 ?? p2; // => this works

            Console.WriteLine($"p1 : {p1}");
            Console.WriteLine($"s : {s}");
            Console.WriteLine($"p2 : {p2}");
            Console.WriteLine($"p3 : {p3}");
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public override string ToString()
            {
                return $"Name:{FirstName} Surname:{LastName}";
            }
        }
    }
}
