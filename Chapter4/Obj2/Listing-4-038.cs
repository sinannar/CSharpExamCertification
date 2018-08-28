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

namespace Chapter4.Obj2
{
    public static class Listing_4_038
    {
        public static void RunMain()
        {
            using (PeopleContext ctx = new PeopleContext())
            {
                ctx.People.Add(new Person() { Id = 1, Name = "John Doe" });
                ctx.SaveChanges();
            }

            using (PeopleContext ctx = new PeopleContext())
            {
                Person person = ctx.People.SingleOrDefault(p => p.Id == 1);
                Console.WriteLine("Retrived person from PeopleContext: {0}", person.Name);
            }
        }

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class PeopleContext : DbContext
        {
            public IDbSet<Person> People { get; set; }
        }
    }
}