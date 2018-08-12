using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpLab.Chapter1.Objective4
{
    public class Listing_1_77
    {
        public delegate TextWriter CovarianceDel();
        public StreamWriter MethodStream() { return null; }
        public StringWriter MethodString() { return null; }

        public void Run()
        {
            CovarianceDel del;
            del = MethodStream;
            del = MethodString;
        }

        public static void RunMain()
        {
            Console.WriteLine("CovarianceDel does not give error so Inheritance in method signature for returned type works fine");
        }
    }
}
