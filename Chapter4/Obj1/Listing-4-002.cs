using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4.Obj1
{
    public static class Listing_4_002
    {
        public static void RunMain()
        {
            var directory = Directory.CreateDirectory(@"C:\Temp\ProgrammingInCSharp\Directory1");            var directoryInfo = new DirectoryInfo(@"C:\Temp\ProgrammingInCSharp\Directory2");            directoryInfo.Create();        }
    }
}