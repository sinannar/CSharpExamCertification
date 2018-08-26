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
    public static class Listing_2_45
    {
        public static void RunMain()
        {

        }

        interface IEntity
        {
            int Id { get; }
        }

        class Repository<T> where T : IEntity
        {
            protected IEnumerable<T> elements;

            public Repository(IEnumerable<T> elements)
            {
                this.elements = elements;
            }

            public T FindById(int id)
            {
                return this.elements.SingleOrDefault(e => e.Id == id);
            }
        }
    }
}
