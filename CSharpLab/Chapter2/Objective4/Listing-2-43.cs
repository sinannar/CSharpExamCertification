using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace CSharpLab.Chapter2.Objective4
{
    public static class Listing_2_43
    {
        public static void RunMain()
        {

        }

        interface IRepository<T>
        {
            T FIndById(int id);

            IEnumerable<T> All();
        }

        class Repository<T> : IRepository<T>
        {
            public List<T> l { get; set; }

            public IEnumerable<T> All()
            {
                return l.ToList();
            }

            public T FIndById(int id)
            {
                return l[id];
            }
        }

        class StringRepository : IRepository<string>
        {
            public string FIndById(int id)
            {
                return "42";
            }

            public IEnumerable<string> All()
            {
                return new List<string>() { "42", "3.14" };
            }
        }

        class DoubleReposiotry : IRepository<double>
        {
            public double FIndById(int id)
            {
                return 42d;
            }

            public IEnumerable<double> All()
            {
                return new List<double>() { 42d, 3.14 };
            }
        }
    }
}
