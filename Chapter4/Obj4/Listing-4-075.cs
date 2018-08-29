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
    public static class Listing_4_075
    {
        public static void RunMain()
        {

        }


        [Serializable]
        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }

            [NonSerialized]            private bool isDirty = false;

            [OnSerializing()]
            internal void OnSerializingMethod(StreamingContext context)
            {
                Console.WriteLine("Serializing");
            }

            [OnSerialized()]
            internal void OnSerializedMethod(StreamingContext context)
            {
                Console.WriteLine("OnSerialized");
            }

            [OnDeserializing()]
            internal void OnDeserializingMethod(StreamingContext context)
            {
                Console.WriteLine("OnDeserializing");
            }

            [OnDeserialized()]
            internal void OnDeserializedMethod(StreamingContext context)
            {
                Console.WriteLine("OnDeserialized");
            }
        }
    }
}
