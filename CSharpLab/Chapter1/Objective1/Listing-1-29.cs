using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_29
    {
        public static void RunMain()
        {
            BlockingCollection<string> col = new BlockingCollection<string>();

            Task read = Task.Run(() =>
            {
                foreach (var item in col.GetConsumingEnumerable())
                {
                    Console.WriteLine(item);
                }
            });

            Task write = Task.Run(() =>
            {
                while(true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) break;
                    col.Add(s);
                }
            });
        }
    }
}
