﻿using System;
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
    public static class Listing_4_018
    {
        public static void RunMain()
        {
            string folder = "folder";
            string uncompressedFilePath = Path.Combine(folder, "uncompressed.dat");
            string compressedFilePath = Path.Combine(folder, "compressed.dat");

            CleanUp(uncompressedFilePath);
            CleanUp(compressedFilePath);

            Directory.CreateDirectory(folder);
            byte[] dataToCompress = Enumerable.Repeat((byte)'a', 1024 * 1024).ToArray();

            using (FileStream uncompressedFileStream = File.Create(uncompressedFilePath))
            {
                uncompressedFileStream.Write(dataToCompress, 0, dataToCompress.Length);
            }

            using (FileStream compressedFileStream = File.Create(compressedFilePath))
            {
                using (GZipStream cmpressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                {
                    cmpressionStream.Write(dataToCompress, 0, dataToCompress.Length);
                }
            }

            FileInfo uncompressedFile = new FileInfo(uncompressedFilePath);
            FileInfo compressedFile = new FileInfo(compressedFilePath);

            Console.WriteLine("uncompressedFile.Length = {0}", uncompressedFile.Length);
            Console.WriteLine("compressedFile.Length = {0}", compressedFile.Length);

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