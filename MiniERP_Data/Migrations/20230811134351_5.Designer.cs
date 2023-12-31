﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mini_ERP.Data;

#nullable disable

namespace MiniERP.Data.Migrations
{
    [DbContext(typeof(MiniERP_DbContext))]
    [Migration("20230811134351_5")]
    partial class _5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4ce09ff9-2be4-478b-a8bf-89ec13f9cee2",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@gmail.com",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEFlT0MTa9HkpExoWfLVxgAIPVcPmwVE/Y05rWjuRUf3CC8U2xDLJ01uf+/m7iz+8XQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7b627c23-48e8-42a7-b161-7a0cbe24e384",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2dea5201-dd39-41bf-b6a6-ef18b067ba65",
                            Email = "user@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "user@gmail.com",
                            NormalizedUserName = "USER",
                            PasswordHash = "AQAAAAEAACcQAAAAEPZl4HT6N/wPIkEfwY6PZvXjrjPcDf/t4r4S/swyyDf+sV7w2GcxBBeI7obn4g+HJg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "75bfe3bd-2bd0-4108-b648-e03dfb3e0cf2",
                            TwoFactorEnabled = false,
                            UserName = "user"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MiniERP.Data.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Клиенти на дружеството с референция към приходните документи, поръчки и адреси за доставка");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<decimal>("TotalTurnover")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("VatNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Bul. Boris III 126",
                            City = "Sofia",
                            IsDeleted = false,
                            Manager = "Ivan Ivanov",
                            Name = "Shopy Shop LTD",
                            PhoneNumber = "0888888888",
                            TotalTurnover = 0m,
                            VatNumber = "200456789"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Bul. Botevgradsko shose 22",
                            City = "Sofia",
                            IsDeleted = false,
                            Manager = "Petar Petrov",
                            Name = "Good Shop2 LTD",
                            PhoneNumber = "0888999999",
                            TotalTurnover = 0m,
                            VatNumber = "205179299"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Bul. Bulgaria 1",
                            City = "Sofia",
                            IsDeleted = false,
                            Manager = "Georgi Georgiev",
                            Name = "Best Shop3 LTD",
                            PhoneNumber = "0888777777",
                            TotalTurnover = 0m,
                            VatNumber = "203174491"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Bul. Bulgaria 1",
                            City = "Sofia",
                            IsDeleted = false,
                            Manager = "Georgi Georgiev",
                            Name = "Best Shop4 LTD",
                            PhoneNumber = "0888777777",
                            TotalTurnover = 0m,
                            VatNumber = "203174491"
                        });
                });

            modelBuilder.Entity("MiniERP.Data.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfInvoice")
                        .HasColumnType("datetime2");

                    b.Property<int>("InvoiceNumber")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("PriceWhitOutVAT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Invoices");

                    b.HasComment("Фактури на клиентите на дружеството");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            DateOfInvoice = new DateTime(2023, 8, 11, 16, 43, 50, 693, DateTimeKind.Local).AddTicks(5642),
                            InvoiceNumber = 1,
                            IsDeleted = false,
                            IsPaid = false,
                            OrderId = 1,
                            PriceWhitOutVAT = 833.3333333333333333333333333m,
                            TotalPrice = 1000m
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            DateOfInvoice = new DateTime(2023, 8, 12, 16, 43, 50, 693, DateTimeKind.Local).AddTicks(5682),
                            InvoiceNumber = 2,
                            IsDeleted = false,
                            IsPaid = false,
                            OrderId = 2,
                            PriceWhitOutVAT = 1666.6666666666666666666666667m,
                            TotalPrice = 2000m
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 3,
                            DateOfInvoice = new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            InvoiceNumber = 3,
                            IsDeleted = false,
                            IsPaid = false,
                            OrderId = 3,
                            PriceWhitOutVAT = 2500m,
                            TotalPrice = 3000m
                        });
                });

            modelBuilder.Entity("MiniERP.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomersId")
                        .HasColumnType("int");

                    b.Property<bool>("HasInvoice")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomersId");

                    b.ToTable("Orders");

                    b.HasComment("Поръчки на клиентите на дружеството");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomersId = 1,
                            HasInvoice = false,
                            IsDeleted = false,
                            TotalPrice = 0m
                        },
                        new
                        {
                            Id = 2,
                            CustomersId = 2,
                            HasInvoice = false,
                            IsDeleted = false,
                            TotalPrice = 0m
                        },
                        new
                        {
                            Id = 3,
                            CustomersId = 3,
                            HasInvoice = false,
                            IsDeleted = false,
                            TotalPrice = 0m
                        });
                });

            modelBuilder.Entity("MiniERP.Data.Models.OwnerCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Данни за дружеството собственик");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("BankAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bulstat")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GeneralManager")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("VatNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WareHouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = " Sofia Bul. Bulgaria 1",
                            BankAccount = "BG80BNBG96611020345678",
                            Bulstat = "BG201174491",
                            CompanyName = "MiniERP",
                            Email = "galiay@gmail.com",
                            GeneralManager = "Galya Stoyanova",
                            PhoneNumber = "0895600500",
                            VatNumber = "201174491",
                            WareHouseId = 1
                        });
                });

            modelBuilder.Entity("MiniERP.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Image")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Products");

                    b.HasComment("Продукти на дружеството");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Coca Cola Zero - sugar free",
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR2S8cwpn-nqRTd2zPBlj-HSevRozPs5bUPeQ&usqp=CAU",
                            IsDeleted = false,
                            IsNew = false,
                            Name = "Coca Cola Zero 330ml",
                            Price = 1.20m,
                            Quantity = 1000
                        },
                        new
                        {
                            Id = 2,
                            Description = "Coca Cola - regular 135 cal.",
                            Image = "https://drenhoreca.rs/images/product/original/0208-svrQ.png",
                            IsDeleted = false,
                            IsNew = true,
                            Name = "Coca Cola 500ml",
                            Price = 1.29m,
                            Quantity = 500
                        },
                        new
                        {
                            Id = 3,
                            Description = "Fanta Lemon 1500ml 555 cal.",
                            Image = "https://avanti-bg.com/wp-content/uploads/2020/06/05400311.png",
                            IsDeleted = false,
                            IsNew = true,
                            Name = "Fanta Lemon",
                            Price = 2.13m,
                            Quantity = 250
                        },
                        new
                        {
                            Id = 4,
                            Description = "Fanta Orange 1500ml 631 cal.",
                            Image = "https://www.cfacdn.com/img/order/menu/Online/Drinks/Bottled/Fanta_Orange_1080x1080.png",
                            IsDeleted = false,
                            IsNew = true,
                            Name = "Fanta Orange",
                            Price = 2.19m,
                            Quantity = 350
                        });
                });

            modelBuilder.Entity("MiniERP.Data.Models.ShipingAdress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Адреси за доставка на клиентите на дружеството");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("CustomersId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("ShippingAdresses");
                });

            modelBuilder.Entity("MiniERP.Data.Models.WareHouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Информация за склада");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("OwnerCompanyId")
                        .HasColumnType("int");

                    b.Property<string>("WareHouseManager")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerCompanyId");

                    b.ToTable("WareHouses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Sofia Bul. Bulgaria 1",
                            Name = "Main WareHouse",
                            OwnerCompanyId = 1,
                            WareHouseManager = "Pesho Peshev"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MiniERP.Data.Models.Invoice", b =>
                {
                    b.HasOne("MiniERP.Data.Models.Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MiniERP.Data.Models.Order", "Order")
                        .WithOne("Invoice")
                        .HasForeignKey("MiniERP.Data.Models.Invoice", "OrderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("MiniERP.Data.Models.Order", b =>
                {
                    b.HasOne("MiniERP.Data.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("MiniERP.Data.Models.Product", b =>
                {
                    b.HasOne("MiniERP.Data.Models.Order", null)
                        .WithMany("Products")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("MiniERP.Data.Models.ShipingAdress", b =>
                {
                    b.HasOne("MiniERP.Data.Models.Customer", null)
                        .WithMany("ShipingAdresses")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("MiniERP.Data.Models.WareHouse", b =>
                {
                    b.HasOne("MiniERP.Data.Models.OwnerCompany", "OwnerCompany")
                        .WithMany("WareHouses")
                        .HasForeignKey("OwnerCompanyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("OwnerCompany");
                });

            modelBuilder.Entity("MiniERP.Data.Models.Customer", b =>
                {
                    b.Navigation("Invoices");

                    b.Navigation("Orders");

                    b.Navigation("ShipingAdresses");
                });

            modelBuilder.Entity("MiniERP.Data.Models.Order", b =>
                {
                    b.Navigation("Invoice");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("MiniERP.Data.Models.OwnerCompany", b =>
                {
                    b.Navigation("WareHouses");
                });
#pragma warning restore 612, 618
        }
    }
}
