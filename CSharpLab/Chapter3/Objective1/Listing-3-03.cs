using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Data.Entity;

namespace CSharpLab.Chapter3.Objective1
{
    public static class Listing_3_03
    {
        public static void RunMain()
        {
            using (ShopContext ctx = new ShopContext())
            {
                Address a = new Address()
                {
                    AddressLine1 = "Somewhere 1",
                    AddressLine2 = "At some floor",
                    City = "SomeCity",
                    ZipCode = "1111AA"
                };

                Customer c = new Customer()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    BillingAddress = a,
                    ShippingAddress = a
                };

                ctx.Customers.Add(c);
                ctx.SaveChanges();
            }
        }

        public class ShopContext : DbContext
        {
            public IDbSet<Customer> Customers { get;set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Customer>()
                    .HasRequired(bm => bm.BillingAddress)
                    .WithMany().WillCascadeOnDelete(false);
            }
        }

        public class Customer
        {
            public int Id { get; set; }

            [Required, MaxLength(20)]
            public string FirstName { get; set; }

            [Required, MaxLength(20)]
            public string LastName { get; set; }

            [Required]
            public Address ShippingAddress { get; set; }

            [Required]
            public Address BillingAddress { get; set; }
        }

        public class Address
        {
            public int Id { get; set; }

            [Required, MaxLength(20)]
            public string AddressLine1 { get; set; }

            [Required, MaxLength(20)]
            public string AddressLine2 { get; set; }

            [Required, MaxLength(20)]
            public string City { get; set; }

            [RegularExpression(@"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$")]
            public string ZipCode { get; set; }
        }

        public static class GenericValidator<T>
        {
            public static IList<ValidationResult> Validate(T entity)
            {
                var results = new List<ValidationResult>();
                var context = new ValidationContext(entity, null, null);
                Validator.TryValidateObject(entity, context, results);

                return results;
            }
        }
    }
}
