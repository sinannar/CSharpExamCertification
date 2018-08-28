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
    public static class Listing_4_017
    {
        public static void RunMain()
        {
            string path = "test.dat"; // Will create file test.dat in the outputdirectory of the project

            using (StreamReader streamWriter = File.OpenText(path))
            {
                Console.WriteLine(streamWriter.ReadLine()); // Displays: MyValue
            }

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}