
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
		public DbSet<ShipingAdress> ShippingAdresses { get; set; } = null!;
		public DbSet<OwnerCompany> Companies { get; set; } = null!;

		public DbSet<WareHouse> WareHouses { get; set; } = null!;

		

		protected override void OnModelCreating(ModelBuilder builder)
		{
			
			builder.ApplyConfigurationsFromAssembly(typeof(MiniERP_DbContext).Assembly);

	

			base.OnModelCreating(builder);
			
		}




	}
}