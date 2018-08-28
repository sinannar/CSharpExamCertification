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
    public static class Listing_4_007
    {
        public static void RunMain()
        {
            Console.WriteLine("1th METHOD");
            foreach (var item in Directory.GetFiles(@"D:\"))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n\n\n\n2th METHOD");
            DirectoryInfo d = new DirectoryInfo(@"D:\");
            foreach (var item in d.GetFiles())
            {
                Console.WriteLine(item.FullName);
            }
        }        
    }
}