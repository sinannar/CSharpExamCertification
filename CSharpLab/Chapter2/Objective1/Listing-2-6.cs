using System;

namespace CSharpLab.Chapter2.Objective1
{
    public static class Listing_2_06
    {
        public static void RunMain()
        {

        }

        /*
         Getting address as parameter make this method less coupled to Customer
        */
        public static Distance CalculateDistanceTo(Address address)
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
