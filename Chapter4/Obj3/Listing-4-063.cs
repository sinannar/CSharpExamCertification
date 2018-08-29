using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.ServiceModel;
using System.Xml;
using System.Xml.XPath;

namespace Chapter4.Obj3
{
    public static class Listing_4_063
    {
        public static void RunMain()
        {
            int[] data = { 1, 2, 5, 8, 11 };
            var result = data.Where(d => d > 5);
            Console.WriteLine(string.Join(", ", result));

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }

    public static class LinqExtensions
    {
        public static IEnumerable<TSource> Where<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, bool> predicate)
        {
            foreach (TSource item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }

}
