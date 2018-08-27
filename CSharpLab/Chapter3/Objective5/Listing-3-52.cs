using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace CSharpLab.Chapter3.Objective5
{
    public static class Listing_3_52
    {
        const int numberOfIterations = 100000;

        public static void RunMain()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Algorithm1();
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            sw.Reset();
            sw.Start();
            Algorithm2();
            sw.Stop();

            Console.WriteLine(sw.Elapsed);
            Console.WriteLine("Ready");
            Console.ReadKey();
        }

        private static void Algorithm2()
        {
            string result = "";
            for (int x = 0; x < numberOfIterations; x++)
            {
                result +='a';
            }
        }
        private static void Algorithm1()
        {
            StringBuilder sb = new StringBuilder();
            for (int x = 0; x < numberOfIterations; x++)
            {
                sb.Append('a');
            }
            string result = sb.ToString();
        }
    }
}

