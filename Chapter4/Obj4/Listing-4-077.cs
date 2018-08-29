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

namespace Chapter4.Obj4
{
    public static class Listing_4_077
    {
        public static void RunMain()
        {

        }


        [DataContract]
        public class PersonDataContract
        {
            [DataMember]
            public int Id { get; set; }
            [DataMember]
            public string Name { get; set; }

            private bool isDirty = false;
        }
    }
}
