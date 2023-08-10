using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniERP.Data.Models;


namespace MiniERP.Data.Configurations
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                    
                        new Product
                        {
                            Id = 1,
                            Description = "Coca Cola Zero - sugar free",
                            Price = 1.20m,
                            Quantity = 1000,
                            Image="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR2S8cwpn-nqRTd2zPBlj-HSevRozPs5bUPeQ&usqp=CAU",
                            IsNew = false,
                            Name="Coca Cola Zero 330ml"
                        },
                        new Product
                        {
                            Id = 2,
                            Description = "Coca Cola - regular 135 cal.",
                            Price = 1.29m,
                            Quantity = 500,
                            Image="https://drenhoreca.rs/images/product/original/0208-svrQ.png",
                            IsNew = true,
                            Name="Coca Cola 500ml"


                        },
                        new Product
                        {
                            Id = 3,
                            Description = "Fanta Lemon 1500ml 555 cal.",
                            Price = 2.13m,
                            Quantity = 250,
                            Image="https://avanti-bg.com/wp-content/uploads/2020/06/05400311.png",
                            IsNew = true,
                            Name="Fanta Lemon"
                        },

                        new Product
                        {
                            Id = 4,
                            Description = "Fanta Orange 1500ml 631 cal.",
                            Price = 2.19m,
                            Quantity = 350,
                            Image="https://www.cfacdn.com/img/order/menu/Online/Drinks/Bottled/Fanta_Orange_1080x1080.png",
                            IsNew = true,
                            Name="Fanta Orange"
                        });


                    
        }
    }
}
