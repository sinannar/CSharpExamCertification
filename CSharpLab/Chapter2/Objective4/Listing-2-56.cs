using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace CSharpLab.Chapter2.Objective4
{
    public static class Listing_2_56
    {
        public static void RunMain()
        {
            

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
                return FirstName + " " + LastName;
            }
        }

        class People : IEnumerable<Person>
        {
            public People(Person[] people)
            {
                this.people = people;
            }

            private Person[] people;

            public IEnumerator<Person> GetEnumerator()
            {
                for (int i = 0; i < people.Length; i++)
                {
                    yield return this.people[i];
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
