using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;

/*
    --- new makes that method not overridden...   
*/
namespace CSharpLab.Chapter2.Objective4
{
    public static class Listing_2_48
    {
        public static void RunMain()
        {
            Base b = new Base();
            b.Execute();
            b = new Derived();
            Derived c = new Derived();
            b.Execute();
            c.Execute();
            ((Base)c).Execute();

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        class Base
        {
            public void Execute() { Console.WriteLine("Base.Execute"); }
        }

        class Derived : Base
        {
            public new void Execute() { Console.WriteLine("Derived.Execute"); }
        }
    }
}
