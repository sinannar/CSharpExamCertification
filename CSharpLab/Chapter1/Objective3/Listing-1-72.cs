using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter1.Objective3
{
    public static class Listing_1_72
    {
        public static void RunMain()
        {
            CannotChangeForeachIterationVariable();

        }

        static void CannotChangeForeachIterationVariable()
        {
            var people = new List<Person>
            {
                new Person(){FirstName="John",LastName="Doe"},
                new Person(){FirstName="John",LastName="Doe"},
            };
            foreach (Person p in people)
            {
                p.LastName = "Changed"; // This is allowed
                                       // p = new Person(); // This gives a compile error
            }
        }

        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
