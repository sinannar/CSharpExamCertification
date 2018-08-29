


using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4.Obj5
{
    public static class Listing_4_090
    {
        public static void RunMain()
        {
           
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
