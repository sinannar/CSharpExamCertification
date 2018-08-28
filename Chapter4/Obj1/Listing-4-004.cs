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
    public static class Listing_4_004
    {
        public static void RunMain()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("TestDirectory");
            directoryInfo.Create();

            DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();
            directorySecurity.AddAccessRule(
                new FileSystemAccessRule("eveyone",FileSystemRights.ReadAndExecute, AccessControlType.Allow));

            //WindowsIdentity currentUser = WindowsIdentity.GetCurrent();
            //foreach (var item in currentUser.Groups)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}