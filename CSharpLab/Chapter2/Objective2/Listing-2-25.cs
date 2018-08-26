using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace CSharpLab.Chapter2.Objective2
{
    public static class Listing_2_25
    {
        public static void RunMain()
        {
            Money m = new Money(42.42M);
            decimal amount = m;
            int truncatedAmount = (int)m;

            Console.WriteLine("amount = {0}", amount);
            Console.WriteLine("truncatedAmount = {0}", truncatedAmount);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        class Money
        {
            public Money(decimal amount)
            {
                this.Amount = amount;
            }

            public decimal Amount { get; set; }

            public static implicit operator decimal(Money money)
            {
                return money.Amount;
            }

            public static explicit operator int(Money money)
            {
                return (int)money.Amount;
            }
        }
    }
}
