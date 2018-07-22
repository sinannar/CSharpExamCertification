using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_09
    {
        public static void RunMain()
        {
            Task<int> t1 = Task.Run(() => {
                return 42;
            });
            Console.WriteLine(t1.Result);
        }
    }
}
