using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_28_1
    {
        public static void RunMain()
        {
            BlockingCollection<string> col = new BlockingCollection<string>();

            Task read = Task.Run(() =>
            {
                //string str = "";
                //while (!str.Equals("Exit",StringComparison.OrdinalIgnoreCase))
                while (true)
                {
                    //str = col.Take();
                    //Console.WriteLine(str);
                    Console.WriteLine(col.Take());
                }
            });

            Task write = Task.Run(() =>
            {
                while(true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) break;
                    var r = s.Split(' ');
                    foreach (var i in r)
                    {
                        col.Add(i);
                    }
                }
            });

            write.Wait();

        }
    }
}
