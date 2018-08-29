﻿using System;
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

namespace Chapter4.Obj3
{
    public static class Listing_4_060
    {
        public static void RunMain()
        {
            var orders = GetOrders();

            var result = from o in orders
                         from l in o.OrderLines
                         group l by l.Product into p
                         select new
                         {
                             Product = p.Key,
                             Amoount = p.Sum(x => x.Amount)
                         };

            var products = from o in orders
                           from ol in o.OrderLines
                           select ol.Product;

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Description} {item.Price}");
            }
        }
        
        public class Product
        {
            public string Description { get; set; }
            public decimal Price { get; set; }
        }
        public class OrderLine
        {
            public int Amount { get; set; }
            public Product Product { get; set; }
        }
        public class Order
        {
            public List<OrderLine> OrderLines { get; set; }
        }

        private static List<Order> GetOrders()
        {
            var product1 = new Product() { Description = "A", Price = 1 };
            var product2 = new Product() { Description = "B", Price = 2 };
            var product3 = new Product() { Description = "C", Price = 3 };
            var orders = new List<Order>()
            {
                new Order()
                {
                    OrderLines = new List<OrderLine>()
                    {
                        new OrderLine()
                        {
                            Amount = 1,
                            Product = product1
                        },
                        new OrderLine()
                        {
                            Amount = 2,
                            Product = product1
                        }
                    }
                },
                new Order()
                {
                    OrderLines = new List<OrderLine>()
                    {
                        new OrderLine()
                        {
                            Amount = 3,
                            Product = product2
                        }
                    }
                },
                new Order()
                {
                    OrderLines = new List<OrderLine>()
                    {
                        new OrderLine()
                        {
                            Amount = 1,
                            Product = product2
                        },
                        new OrderLine()
                        {
                            Amount = 1,
                            Product = product2
                        },
                        new OrderLine()
                        {
                            Amount = 1,
                            Product = product3
                        }
                    }
                },
            };

            return orders;
        }
    }
}
