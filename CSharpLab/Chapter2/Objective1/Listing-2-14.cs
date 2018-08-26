using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLab.Chapter2.Objective1
{
    public static class Listing_2_14
    {
        public static void RunMain()
        {

        }

        class MyClass<T> where T : class, new()
        {
            public MyClass()
            {
                MyProperty = new T();
            }

            T MyProperty { get; set; }
        }
    }
}
