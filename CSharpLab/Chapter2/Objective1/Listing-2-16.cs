using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLab.Chapter2.Objective1
{
    public static class Listing_2_16
    {
        
        public static void RunMain()
        {
            UnknownToOthersNamespace.Product p = new UnknownToOthersNamespace.Product() { Price = 1000 };
            UnknownToOthersNamespace.Calculator calc = new UnknownToOthersNamespace.Calculator();
            Console.WriteLine("Discount of {0} is {1}", p.Price, calc.CalculateDiscount(p));

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}

namespace UnknownToOthersNamespace{
    public class Product
    {
        public decimal Price { get; set; }
    }

    /*
        IF I PUT THIS IN STATIC CLASS Listing_2_16, I got this error
        Severity	Code	Description	Project	File	Line	Suppression State
        Error	CS1109	Extension methods must be defined in a top level static class; MyExtensions is a nested class	CSharpLab	C:\Users\sinan\source\repos\CSharpExamCertification\CSharpLab\Chapter2\Objective1\Listing-2-16.cs	21	Active
    */
    public static class MyExtensions
    {
        public static decimal Discount(this Product product)
        {
            return product.Price * .9M;
        }
    }

    public class Calculator
    {
        public decimal CalculateDiscount(Product p)
        {
            return p.Discount();
        }
    }
}
