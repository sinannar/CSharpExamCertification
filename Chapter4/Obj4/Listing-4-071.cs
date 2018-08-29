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

namespace Chapter4.Obj4
{
    public static class Listing_4_071
    {
        public static void RunMain()
        {
           
        }

        [Serializable]
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        [Serializable]
        public class Order
        {
            [XmlAttribute]
            public int ID { get; set; }
            [XmlIgnore]
            public bool IsDirty { get; set; }
            [XmlArray("Lines")]
            [XmlArrayItem("OrderLine")]
            public List<OrderLine> OrderLines { get; set; }
        }

        [Serializable]
        public class VIPOrder : Order
        {
            public string Description { get; set; }
        }

        [Serializable]
        public class OrderLine
        {
            [XmlAttribute]
            public int ID { get; set; }
            [XmlAttribute]
            public int Amount { get; set; }
            [XmlElement("OrderedProduct")]
            public Product Product { get; set; }
        }

        [Serializable]
        public class Product
        {
            [XmlAttribute]
            public int ID { get; set; }
            public decimal Price { get; set; }
            public string Description { get; set; }
        }
    }
}
