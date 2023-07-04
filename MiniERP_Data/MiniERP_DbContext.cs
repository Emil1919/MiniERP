using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mini_ERP.Data
{
	public class MiniERP_DbContext : IdentityDbContext
    {
        public MiniERP_DbContext(DbContextOptions<MiniERP_DbContext> options)
            : base(options)
        {
        }
    }
}