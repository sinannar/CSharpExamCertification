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
    public static class Listing_4_076
    {
        public static void RunMain()
        {

        }


        [Serializable]
        public class PersonComplex : ISerializable
        {
            public int Id { get; set; }
            public string Name { get; set; }
            private bool isDirty = false;

            public PersonComplex()
            { }

            protected PersonComplex(SerializationInfo info, StreamingContext context)
            {
                this.Id = info.GetInt32("Value1");
                this.Name = info.GetString("Value2");
                this.isDirty = info.GetBoolean("Value3");
            }

            [SecurityPermission(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter = true)]
            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("Value1", Id);
                info.AddValue("Value2", Name);
                info.AddValue("Value3", isDirty);
            }
        }
    }
}
