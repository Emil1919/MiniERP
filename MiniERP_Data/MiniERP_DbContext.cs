using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MiniERP.Data.Models;

namespace Mini_ERP.Data
{
    public class MiniERP_DbContext : IdentityDbContext
	{
		public MiniERP_DbContext(DbContextOptions<MiniERP_DbContext> options)
			: base(options)
		{
			
		}
		public DbSet<Invoice> Invoices { get; set; } = null!;
		public DbSet<Customer> Customers { get; set; } = null!;
		public DbSet<Order> Orders { get; set; } = null!;
		public DbSet<Product> Products { get; set; } = null!;
		public DbSet<ShipingAdress> Shippings { get; set; } = null!;
		public DbSet<Owner> Owners { get; set; } = null!;
		

		protected override void OnModelCreating(ModelBuilder builder)
		{
			

			builder.Entity<Invoice>()
				.HasOne(i => i.Order)
				.WithOne(o=>o.Invoice)
				.HasForeignKey<Invoice>( v => v.OrderId)
				.OnDelete(DeleteBehavior.Restrict);


			builder.Entity<Customer>().HasMany(i=>i.Invoices)
				.WithOne(c=>c.Customer)
				.HasForeignKey(c=>c.CustomerId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Customer>().HasMany(o=>o.Orders)
				.WithOne(c=>c.Customer)
				.HasForeignKey(c=>c.CustomersId)
				.OnDelete(DeleteBehavior.Restrict);
			

			//builder.Entity<Order>().HasOne(o=>o.Invoice)


			base.OnModelCreating(builder);
			
		}




	}
}