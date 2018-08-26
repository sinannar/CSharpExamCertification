using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;

namespace CSharpLab.Chapter2.Objective5
{
    public static class Listing_2_72
    {

        public static void RunMain()
        {
            int integer = 8;
            Console.WriteLine("DumpObject with int:");
            DumpObject(integer);

            MyClass myObject = new MyClass(1, 123);
            Console.WriteLine("DumpObject with MyClass:");
            DumpObject(myObject);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        static void DumpObject(object obj)
        {
            FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (FieldInfo field in fields)
            {
                //if (field.FieldType == typeof(int))
                //{
                    Console.WriteLine(field.GetValue(obj));
                //}
            }
        }

        class MyClass
        {
            public MyClass(int id, int number)
            {
                this.Id = id;
                this.Number = number;
            }

            public int Id { get; set; }

            public int Number { get; set; }

            private int x = 3;
        }
    }
}

