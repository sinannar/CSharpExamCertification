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
    public static class Listing_2_54
    {
        public static void RunMain()
        {
            List<Order> orders = new List<Order>
            {
                new Order { Created = new DateTime(2012, 12, 1 )},
                new Order { Created = new DateTime(2012, 1, 6 )},
                new Order { Created = new DateTime(2012, 7, 8 )},
                new Order { Created = new DateTime(2012, 2, 20 )},
            };
            Console.WriteLine("\nBefore sort");
            PrintOrders(orders);

            orders.Sort();
            Console.WriteLine("\nAfter sort");
            PrintOrders(orders);

            Console.Write("\nPress a key to exit");
            Console.ReadKey();
        }

        private static void PrintOrders(List<Order> orders)
        {
            foreach (var order in orders)
            {
                Console.WriteLine(order.Created.ToString());
            }
        }

        class Order : IComparable
        {
            public DateTime Created { get; set; }

            public int CompareTo(object obj)
            {
                if (obj == null)
                {
                    return 1;
                }

                Order other = obj as Order;
                if (other == null)
                {
                    throw new ArgumentException("Object is not an Order");
                }

                return this.Created.CompareTo(other.Created);
            }
        }
    }
}
