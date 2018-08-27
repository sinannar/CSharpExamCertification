using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace CSharpLab.Chapter3.Objective5
{
    public static class Listing_3_47
    {
        public static void RunMain()
        {
            Stream outputFile = File.Create("tracefile.txt");
            TextWriterTraceListener textListener = new TextWriterTraceListener(outputFile);

            TraceSource traceSource = new TraceSource("myTraceSource", SourceLevels.All);

            traceSource.Listeners.Clear();
            traceSource.Listeners.Add(textListener);

            traceSource.TraceInformation("Trace output");

            traceSource.Flush();
            traceSource.Close();


            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}

