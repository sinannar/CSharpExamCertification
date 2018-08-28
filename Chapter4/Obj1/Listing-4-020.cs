using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4.Obj1
{
    public static class Listing_4_020
    {
        public static void RunMain()
        {
            var result = ReadAllText();

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }

        private static object ReadAllText()
        {
            string path = "test.txt";

            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            return string.Empty;
        }
    }
}