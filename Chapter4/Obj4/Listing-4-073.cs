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
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Chapter4.Obj4
{
    public static class Listing_4_073
    {
        public static void RunMain()
        {
            var path = "data.bin";
            InitializeFile(path);

            Person p = new Person
            {
                Id = 1,
                Name = "John Doe"
            };
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(path, FileMode.Open))
            {
                formatter.Serialize(stream, p);
                Console.WriteLine("Serialized ...");
            }

            using (Stream stream = new FileStream(path, FileMode.Open))
            {
                Person dp = (Person)formatter.Deserialize(stream);
                Console.WriteLine("Deserialize ...");
            }

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }

        
        [Serializable]
        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            private bool isDirty = false;
        }

        private static void InitializeFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("{0} deleted", path);
            }

            File.Create(path).Close();
            Console.WriteLine("{0} created", path);
        }
    }
}
