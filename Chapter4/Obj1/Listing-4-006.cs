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
    public static class Listing_4_006
    {
        public static void RunMain()
        {
            var d1Str = @"C:\Temp\ProgrammingInCSharp\Directory1";
            var d2Str = @"C:\Temp\ProgrammingInCSharp\Directory2";
            Directory.Move(d1Str, d2Str);
            DirectoryInfo d = new DirectoryInfo(d1Str);
            d.MoveTo(d2Str);
        }        
    }
}