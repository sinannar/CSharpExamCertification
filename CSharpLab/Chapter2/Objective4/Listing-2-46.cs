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
    public static class Listing_2_46
    {
        public static void RunMain()
        {
            OrderRepository repository = new OrderRepository(new List<Order> { new Order(1), new Order(2) });
            Order secondOrder = repository.FindById(2);
            Console.WriteLine(string.Format("secondOrder.Id is {0}", secondOrder.Id));
            IEnumerable<Order> filteredOrders = repository.FilterOrdersOnAmount(42);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        interface IEntity
        {
            int Id { get; }
        }

        class Repository<T> where T : IEntity
        {
            protected IEnumerable<T> elements;

            public Repository(IEnumerable<T> elements)
            {
                this.elements = elements;
            }

            public T FindById(int id)
            {
                return this.elements.SingleOrDefault(e => e.Id == id);
            }
        }

        class Order : IEntity
        {
            public int Id { get; private set; }
            public Order(int id)
            {
                this.Id = id;
            }
        }

        class OrderRepository : Repository<Order>
        {
            public OrderRepository(IEnumerable<Order> orders)
            : base(orders) { }

            public IEnumerable<Order> FilterOrdersOnAmount(decimal amount)
            {
                List<Order> result = null;
                // Some filtering code

                return result;
            }
        }
    }
}
