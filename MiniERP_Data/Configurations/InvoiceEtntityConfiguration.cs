using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniERP.Data.Models;


namespace MiniERP.Data.Configurations
{
    public class InvoiceEtntityConfiguration : IEntityTypeConfiguration<Invoice>
    {
        /// <summary>
        /// Seed Data
        /// Configure Invoice Entity
        /// </summary>
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.HasOne(i => i.Order)
                .WithOne(o => o.Invoice)
                .HasForeignKey<Invoice>(v => v.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                               new Invoice
                               {
                                   Id = 1,
                                   OrderId = 1,
                                   InvoiceNumber = 1,
                                   CustomerId = 1,
                                   DateOfInvoice = DateTime.Now,
                                   IsPaid = false,
                                   TotalPrice = 1000,
                                   PriceWhitOutVAT = 1000 / 1.2m
                               },
                               new Invoice
                               {
                                   Id = 2,
                                   OrderId = 2,
                                   InvoiceNumber = 2,
                                   CustomerId = 2,
                                   DateOfInvoice = DateTime.Now.AddDays(1),
                                   IsPaid = false,
                                   TotalPrice = 2000,
                                   PriceWhitOutVAT = 2000 / 1.2m
                               },
                               new Invoice
                               {
                                   Id = 3,
                                   OrderId = 3,
                                   InvoiceNumber = 3,
                                   CustomerId = 3,
                                   DateOfInvoice = DateTime.Today.AddDays(2),
                                   IsPaid = false,
                                   TotalPrice = 3000,
                                   PriceWhitOutVAT = 3000 / 1.2m
                               });
                   
        }
    }
}
