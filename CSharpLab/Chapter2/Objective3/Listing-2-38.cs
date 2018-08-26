using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace CSharpLab.Chapter2.Objective3
{
    public static class Listing_2_38
    {
        public static void RunMain()
        {
            // This will not complie
            DbContext ctx = new DbContext("Non existing connection string");
            var context = ctx.ObjectContext;

            var adapterContext = ((IObjectContextAdapter)ctx).ObjectContext;
        }

        public interface IObjectContextAdapter
        {
            ObjectContext ObjectContext { get; }
        }

        public class DbContext : IObjectContextAdapter
        {
            public ObjectContext ObjectContext => throw new NotImplementedException();

            public DbContext(string str)
            {

            }
        }

        public class ObjectContext
        {

        }
    }
}
