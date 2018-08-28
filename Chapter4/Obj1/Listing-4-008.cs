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
    public static class Listing_4_008
    {
        public static void RunMain()
        {
            string path = @"d:/testtetetetetet.txt";


            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine($"{path} deleted");
            }

            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                f.Delete();
                Console.WriteLine($"{path} deleted");
            }

        }
    }
}