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
    public static class Listing_4_016
    {
        public static void RunMain()
        {
            string path = "test.dat"; // Will create file test.dat in the outputdirectory of the project
            CleanUp(path);
            using (StreamWriter streamWriter = File.CreateText(path))
            {
                string myValue = "MyValue";
                Console.WriteLine("Writing {0}", myValue);
                streamWriter.Write(myValue);
            }

            Console.WriteLine("Data wrote.");

            using (FileStream fileStream = File.OpenRead(path))
            {
                byte[] data = new byte[fileStream.Length];

                for (int index = 0; index < fileStream.Length; index++)
                {
                    data[index] = (byte)fileStream.ReadByte();
                }

                Console.WriteLine("Reading with FileStream: {0}", Encoding.UTF8.GetString(data));
            }

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