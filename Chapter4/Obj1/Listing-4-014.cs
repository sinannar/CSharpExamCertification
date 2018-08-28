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
    public static class Listing_4_014
    {
        public static void RunMain()
        {
            string path = "test.dat"; // Will create file test.dat in the outputdirectory of the project

            CleanUp(path);

            using (FileStream fileStream = File.Create(path))
            {
                string myValue = "MyValue";
                byte[] data = Encoding.UTF8.GetBytes(myValue);
                Console.WriteLine("Writing {0}", data.ToSentenceCase());
                fileStream.Write(data, 0, data.Length);
            }

            Console.WriteLine("Data wrote.");
            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }

        private static void CleanUp(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("{0} deleted", path);
            }
        }
    }
}