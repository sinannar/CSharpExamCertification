


using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4.Obj5
{
    public static class Listing_4_091
    {
        public static void RunMain()
        {
            PeopleCollection pc = new PeopleCollection() { new Person() { Age = 22, FirstName = "Janne", LastName = "Doe" } };
            pc.Add(new Person() { Age = 21, LastName = "Doe", FirstName = "John" });
            pc.Add(new Person() { Age = 21, LastName = "Do1e", FirstName = "John" });
            pc.Add(new Person() { Age = 21, LastName = "Do11e", FirstName = "John" });

            Console.WriteLine("Count: {0}, Contents: {1}", pc.Count, pc.ToString());
            Console.WriteLine("Removing persons with 21 age...");
            pc.RemoveByAge(21);
            Console.WriteLine("Count: {0}, Contents: {1}", pc.Count, pc.ToString());

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        public class PeopleCollection : List<Person>
        {
            public void RemoveByAge(int age)
            {
                for (int i = this.Count-1; i >=0; i--)
                {
                    if(this[i].Age == age)
                    {
                        this.RemoveAt(i);
                    }
                }
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                foreach (Person p in this)
                {
                    sb.AppendFormat("{0} {1} is {2}; ", p.FirstName, p.LastName, p.Age);
                }

                return sb.ToString();
            }

        }
    }
}
