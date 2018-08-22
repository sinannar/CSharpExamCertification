using System;

namespace CSharpLab.Chapter2.Objective1
{
    public static class Listing_2_05
    {
        public static void RunMain()
        {
            
        }

        /*
         Getting customer as parameter make this method more coupled to Customer
        */
        public static Distance CalculateDistanceTo(Customer customer)
        {
            Distance result = new Distance();
            //...
            return result;
        }

        public class Distance
        {
            //...
        }

        public class Customer
        {
            //...
        }

        public class Address
        {
            //...
        }
    }
}
