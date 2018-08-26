using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace CSharpLab.Chapter2.Objective7
{
    public static class Listing_2_96
    {
        public static void RunMain()
        {
            Person p = new Person("John", "Doe");
            Console.WriteLine(p);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        class Person
        {
            public Person(string firstName, string lastName)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }

            public override string ToString()
            {
                return this.FirstName + " " + this.LastName;
            }
        }
    }
}


