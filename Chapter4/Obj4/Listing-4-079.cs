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
using System.Security.Permissions;
using System.Runtime.Serialization.Json;

namespace Chapter4.Obj4
{
    public static class Listing_4_079
    {
        public static void RunMain()
        {
            Person p = new Person
            {
                Id = 1,
                Name = "John Doe"
            };


            using (MemoryStream stream = new MemoryStream())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));
                ser.WriteObject(stream, p);

                stream.Position = 0;
                StreamReader streamReader = new StreamReader(stream);
                Console.WriteLine("Serialized JSON: {0}", streamReader.ReadToEnd());

                stream.Position = 0;
                Person result = (Person)ser.ReadObject(stream);
            }

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }


        [DataContract]
        public class Person
        {
            [DataMember]
            public int Id { get; set; }
            [DataMember]
            public string Name { get; set; }
        }
    }
}
