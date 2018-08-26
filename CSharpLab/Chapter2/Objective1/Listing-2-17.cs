using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLab.Chapter2.Objective1
{
    public static class Listing_2_17
    {
        public static void RunMain()
        {
            Base b = new Base();
            Console.WriteLine("Base.MyMethod(): {0}", b.MyMethod());
            Derived d = new Derived();
            Console.WriteLine("Derived.MyMethod(): {0}", d.MyMethod());

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        class Base
        {
            public virtual int MyMethod()
            {
                return 42;
            }
        }

        class Derived : Base
        {
            public override int MyMethod()
            {
                return base.MyMethod() * 2;
            }
        }
    }   
}
