using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4.Obj1
{
    public static class Listing_4_003
    {
        public static void RunMain()
        {
            var d1Str = @"C:\Temp\ProgrammingInCSharp\Directory1";
            var d2Str = @"C:\Temp\ProgrammingInCSharp\Directory2";
            if(Directory.Exists(d1Str))
            {
                Directory.Delete(d1Str);
            }

            var directoryInfo = new DirectoryInfo(d2Str);
            if(directoryInfo.Exists)
            {
                directoryInfo.Delete();
            }
        }
    }
}