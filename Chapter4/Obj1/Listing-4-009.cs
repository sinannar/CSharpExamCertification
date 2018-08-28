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
    public static class Listing_4_009
    {
        public static void RunMain()
        {
            string path = "test.text";
            string destPath = "testNewName.text";

            if(!File.Exists(path))
                File.CreateText(path).Close();

            if (File.Exists(destPath))
                File.Delete(destPath);

            File.Move(path, destPath);

            if (File.Exists(destPath))
                File.Delete(destPath);

            File.CreateText(path).Close();
            FileInfo fileInfo = new FileInfo(path);
            fileInfo.MoveTo(destPath);
        }
    }
}