using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4.Obj1
{
    public static class Listing_4_023
    {
        public static void RunMain()
        {
            var task = CreateAndWriteAsyncToFile();

            while (!task.IsCompleted)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }

        private static async Task CreateAndWriteAsyncToFile()
        {
            var path = "test.dat";
            CleanUp(path);

            using (FileStream stream = new FileStream(path,FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
            {
                byte[] data = new byte[int.MaxValue/1000];
                new Random().NextBytes(data);
                Console.WriteLine($"Writing data to {path}");

                await stream.WriteAsync(data, 0, data.Length);
            }
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