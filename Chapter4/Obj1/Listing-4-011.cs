using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4.Obj1
{
    public static class Listing_4_011
    {
        public static void RunMain()
        {
            string folder = @"C:\test";
            string file = "testNewName.text";

            string fullp = folder + file;
            Console.WriteLine("concat: "+fullp);
            Console.ReadKey();

        }
    }
}