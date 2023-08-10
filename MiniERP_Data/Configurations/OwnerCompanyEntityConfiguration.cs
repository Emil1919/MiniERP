using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniERP.Data.Models;



namespace MiniERP.Data.Configurations
{
    public class OwnerCompanyEntityConfiguration : IEntityTypeConfiguration<OwnerCompany>
    {
        /// <summary>
        /// seed data
        /// Set relation with WareHouse
        /// </summary>
        public void Configure(EntityTypeBuilder<OwnerCompany> builder)
        {
            builder.HasMany(w => w.WareHouses)
                .WithOne(c => c.OwnerCompany)
                .HasForeignKey(c => c.OwnerCompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                               new OwnerCompany
                               {
                                   Id = 1,
                                   CompanyName = "MiniERP",
                                   Address = " Sofia Bul. Bulgaria 1",

                                   VatNumber = "201174491",
                                   GeneralManager = "Galya Stoyanova",
                                   PhoneNumber = "0895600500",
                                   Email = "galiay@gmail.com",
                                   BankAccount = "BG80BNBG96611020345678",
                                   Bulstat = "BG201174491",
                                   WareHouseId = 1
                                   


                               }) ;
        }
    }
}
