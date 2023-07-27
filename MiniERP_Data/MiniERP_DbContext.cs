using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MiniERP.Data.Models.CustomerData;
using MiniERP.Data.Models.OwnerData;

namespace Mini_ERP.Data
{
	public class MiniERP_DbContext : IdentityDbContext
    {
        public MiniERP_DbContext(DbContextOptions<MiniERP_DbContext> options)
            : base(options)
        {

        }
        DbSet<Invoice> Invoices { get; set; } = null!;
        DbSet<Customer> Customers { get; set; } = null!;
        DbSet<Order> Orders { get; set; } = null!;
        DbSet<Product> Products { get; set; } = null!;
        DbSet<ShipingAdress> Shippings { get; set; } = null!;
        DbSet<Owner> Owners { get; set; } = null!;
        

    }
}