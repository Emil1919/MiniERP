using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniERP.Data.Models;


namespace MiniERP.Data.Configurations
{
    public class WareHouseEntityConfig : IEntityTypeConfiguration<WareHouse>
    {
        public void Configure(EntityTypeBuilder<WareHouse> builder)
        {
           builder.HasOne(w => w.OwnerCompany)
                .WithMany(c => c.WareHouses)
                .HasForeignKey(c => c.OwnerCompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new WareHouse
                {
                    Id = 1,
                    Name = "Main WareHouse",
                    Address = "Sofia Bul. Bulgaria 1",
                    WareHouseManager = "Pesho Peshev",
                    OwnerCompanyId = 1
                }
                ) ;
        }
    }
}
