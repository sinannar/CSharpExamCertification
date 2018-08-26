using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLab.Chapter2.Objective1
{
    public static class Listing_2_15
    {
        public static void RunMain()
        {
            MyGenericMethod2<int>();
            MyGenericMethod2<string>();
            MyGenericMethod2<bool>();
            MyGenericMethod2<A>();
            MyGenericMethod3<int>();
            //MyGenericMethod3<string>();
            MyGenericMethod3<bool>();
            MyGenericMethod3<A>();
        }

        public class A
        {
            public string MyProperty { get; set; }

            public A()
            {
                MyProperty = "Default Constructor";
            }

            public override string ToString()
            {
                return string.IsNullOrWhiteSpace(MyProperty) ? "IsNullOrWhiteSpace" : MyProperty;
            }
        }

        public static T MyGenericMethod<T>()
        {
            T defaultValue = default(T);
            return defaultValue;
        }

        public static void MyGenericMethod2<T>()
        {
            T defaultValue = default(T);
            Console.WriteLine(
                defaultValue == null ?
                    "NULL" :
                    string.IsNullOrWhiteSpace(defaultValue.ToString()) ?
                        "IsNullOrWhiteSpace" :
                        defaultValue.ToString());
        }

        public static void MyGenericMethod3<T>() where T : new()
        {
            T defaultValue = new T();
            Console.WriteLine(
                defaultValue == null ?
                    "NULL" :
                    string.IsNullOrWhiteSpace(defaultValue.ToString()) ?
                        "IsNullOrWhiteSpace" :
                        defaultValue.ToString());
        }
    }
}
