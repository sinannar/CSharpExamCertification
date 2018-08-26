using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace CSharpLab.Chapter2.Objective5
{
    public static class Listing_2_61
    {
        public static void RunMain()
        {
            if (Attribute.IsDefined(typeof(Person), typeof(SerializableAttribute)))
            {
                Console.WriteLine(string.Format("Person has a Serializable attribute: {0}", typeof(SerializableAttribute)));
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        [Serializable]
        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
