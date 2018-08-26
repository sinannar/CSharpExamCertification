using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLab.Chapter2.Objective1
{
    public static class Listing_2_18
    {
        public static void RunMain()
        {
            Base b = new Base();
            Console.WriteLine("Base.MyMethod(): {0}", b.MyMethod());

            Derived d11 = new Derived();
            Base d12 = new Derived();
            Console.WriteLine("Derived.MyMethod(): {0}", d11.MyMethod());
            Console.WriteLine("Derived Base.MyMethod(): {0}", d12.MyMethod());

            Derived2 d21 = new Derived2();
            Base d22 = new Derived2();
            Console.WriteLine("Derived2.MyMethod(): {0}", d21.MyMethod());
            Console.WriteLine("Derived2 Base.MyMethod(): {0}", d22.MyMethod());

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

        sealed class Derived2 : Derived
        {
            // This line would give an compile error
            public override int MyMethod()
            {
                return 1;
            }
        }

        class Derived3 : Base
        {
            public sealed override int MyMethod()
            {
                return base.MyMethod() * 2;
            }
        }

        /*
            SEALED CLASS VS SEALED METHOD 
        */

        class Derived4 : Derived3
        {
            /*
                Severity	Code	Description	Project	File	Line	Suppression State
                Error	CS0239	'Listing_2_18.Derived4.MyMethod()': cannot override inherited member 'Listing_2_18.Derived3.MyMethod()' because it is sealed	CSharpLab	C:\Users\sinan\source\repos\CSharpExamCertification\CSharpLab\Chapter2\Objective1\Listing-2-18.cs	63	Active
            */
            //public override int MyMethod()
            //{
            //    return base.MyMethod() * 2;
            //}
        }

        /*
            Severity	Code	Description	Project	File	Line	Suppression State
            Error	CS0509	'Listing_2_18.Derived3': cannot derive from sealed type 'Listing_2_18.Derived2'	CSharpLab	C:\Users\sinan\source\repos\CSharpExamCertification\CSharpLab\Chapter2\Objective1\Listing-2-18.cs	53	Active
        */
        //class Derived3 : Derived2
        //{
        //   ...
        //}
    }   
}
