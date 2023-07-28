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


	}
}