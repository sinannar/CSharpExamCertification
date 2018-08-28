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
    public static class Listing_4_010
    {
        public static void RunMain()
        {
            string path = "test.text";
            string destPath = "testNewName.text";

            CleanUp(path, destPath);

            File.CreateText(path).Close();
            File.Copy(path, destPath);

            CleanUp(path, destPath);

            File.CreateText(path).Close();
            FileInfo f = new FileInfo(path);
            f.CopyTo(destPath);

        }

        private static void CleanUp(string path, string destPath)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("{0} deleted", path);
            }

            if (File.Exists(destPath))
            {
                File.Delete(destPath);
                Console.WriteLine("{0} deleted", destPath);
            }
        }
    }
}