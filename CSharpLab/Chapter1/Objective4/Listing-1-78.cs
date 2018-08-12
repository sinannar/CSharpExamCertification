using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpLab.Chapter1.Objective4
{
    public class Listing_1_78
    {
        public delegate void Contravariance1(StreamWriter sw);
        public delegate void Contravariance2(StringWriter sw);
        public void MethodStream(TextWriter sw) {  }

        public void Run()
        {
            Contravariance1 del1;
            Contravariance2 del2;
            del1 = MethodStream;
            del2 = MethodStream;
        }

        public static void RunMain()
        {
            Console.WriteLine("Contravariance does not give error so Inheritance in method signature for returned type works fine");
        }
    }
}
