using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniERP.Data.Models;


namespace MiniERP.Data.Configurations
{
    public class OrderEntityConfiguration : IEntityTypeConfiguration<Order>
    {
        /// <summary>
        /// Seed Data
        /// Configure Order Entity
        /// </summary>
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomersId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new Order
                {
                    Id = 1,
                    CustomersId = 1

                },
            new Order
            {
                Id = 2,
                CustomersId = 2

            },

           new Order
           {
               Id = 3,
               CustomersId = 3,


           });

        }
    }
}
