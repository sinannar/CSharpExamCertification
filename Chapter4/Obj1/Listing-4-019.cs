using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4.Obj1
{
    public static class Listing_4_019
    {
        public static void RunMain()
        {
            string path = "bufferedStream.txt"; // Will create file bufferedStream.txt in the outputdirectory of the project
            CleanUp(path);

            using (FileStream fileStream = File.Create(path))
            {
                using (BufferedStream bufferedStream = new BufferedStream(fileStream))
                {
                    using (StreamWriter streamWriter = new StreamWriter(bufferedStream))
                    {
                        streamWriter.Write("A line of text");
                        Console.WriteLine("Data wrote.");
                    }
                }
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