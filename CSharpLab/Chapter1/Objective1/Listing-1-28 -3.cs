using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_28_3
    {
        public static void RunMain()
        {
            ConcurrentStack<string> col = new ConcurrentStack<string>();


            Task read = Task.Run(() =>
            {
                
                while (true)
                {
                    string str;
                    if(col.TryPop(out str))
                    Console.WriteLine(str);
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
                        col.Push(i);
                    }
                }
            });

            write.Wait();

        }
    }
}
