using System;
using System.Reflection;

namespace CSharpLab.Chapter3.Objective4
{
    public static class Listing_3_36
    {
        public static void RunMain()
        {

        }

        public static Assembly LoadAssembly<T>()
        {
#if !WINRT
            Assembly assembly = typeof(T).Assembly;
#else
            Assembly assembly = typeof(T).GetTypeInfo().Assembly;
#endif
            return assembly;
        }
    }
}
