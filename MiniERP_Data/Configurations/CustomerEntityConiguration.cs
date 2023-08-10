using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniERP.Data.Models;


namespace MiniERP.Data.Configurations
{
    public class CustomerEntityConiguration : IEntityTypeConfiguration<Customer>
    {
        /// <summary>
        /// Configure Customer Entity
        /// Seed Data
        /// </summary>
        
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasMany(i => i.Invoices)
                .WithOne(c => c.Customer)
                .HasForeignKey(c => c.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(o => o.Orders)
                .WithOne(c => c.Customer)
                .HasForeignKey(c => c.CustomersId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new Customer
                {
                    Id = 1,
                    Name = "Shopy Shop LTD",
                    Address = "Bul. Boris III 126",
                    City = "Sofia",
                    VatNumber = "200456789",
                    Manager = "Ivan Ivanov",
                    PhoneNumber = "0888888888",


                },
                new Customer
                {
                    Id = 2,
                    Name = "Good Shop2 LTD",
                    Address = "Bul. Botevgradsko shose 22",
                    City = "Sofia",
                    VatNumber = "205179299",
                    Manager = "Petar Petrov",
                    PhoneNumber = "0888999999",

                },
                new Customer
                {
                    Id = 3,
                    Name = "Best Shop3 LTD",
                    Address = "Bul. Bulgaria 1",
                    City = "Sofia",
                    VatNumber = "203174491",
                    Manager = "Georgi Georgiev",
                    PhoneNumber = "0888777777",
                },
                 new Customer
                {
                Id = 4,
                Name = "Best Shop4 LTD",
                Address = "Bul. Bulgaria 1",
                City = "Sofia",
                VatNumber = "203174491",
                Manager = "Georgi Georgiev",
                PhoneNumber = "0888777777",
                });
        }
    }
}
