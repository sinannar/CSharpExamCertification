using System;
using System.Diagnostics;
using System.Reflection;

namespace CSharpLab.Chapter3.Objective5
{
    public static class Listing_3_46
    {
        public static void RunMain()
        {
            TraceSource traceSource = new TraceSource("myTraceSource", SourceLevels.All);

            traceSource.TraceInformation("Tracing application.");
            traceSource.TraceEvent(TraceEventType.Critical, 0, "Critical trace");
            traceSource.TraceData(TraceEventType.Information, 1, new object[] { "a", "b", "c" });

            traceSource.Flush();
            traceSource.Close();

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}

