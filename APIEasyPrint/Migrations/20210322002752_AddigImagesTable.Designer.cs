﻿// <auto-generated />
using System;
using APIEasyPrint.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EasyPrintWebSite.Migrations.StucturDb
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210322002752_AddigImagesTable")]
    partial class AddigImagesTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APIEasyPrint.Models.Address", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("adressLine")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<double>("latitude")
                        .HasColumnType("float");

                    b.Property<double>("latitudeDelta")
                        .HasColumnType("float");

                    b.Property<double>("longitude")
                        .HasColumnType("float");

                    b.Property<double>("longitudeDelta")
                        .HasColumnType("float");

                    b.Property<string>("neighborhood")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("postcode")
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("street")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("UserId");

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("APIEasyPrint.Models.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("admins");
                });

            modelBuilder.Entity("APIEasyPrint.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("applicationUsers");
                });

            modelBuilder.Entity("APIEasyPrint.Models.CheckoutDetailes", b =>
                {
                    b.Property<Guid>("invoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("deliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("orderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("paymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("paymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("invoiceId");

                    b.HasIndex("orderId");

                    b.ToTable("checkoutDetailes");
                });

            modelBuilder.Entity("APIEasyPrint.Models.CourceMaterial", b =>
                {
                    b.Property<Guid>("courceMaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("courceMaterialDescreption")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<double>("courceMaterialPrice")
                        .HasColumnType("float");

                    b.Property<string>("courceMaterialTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("isAvailable")
                        .HasColumnType("bit");

                    b.Property<Guid>("printingShopId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("courceMaterialId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("printingShopId");

                    b.ToTable("courceMaterials");
                });

            modelBuilder.Entity("APIEasyPrint.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("APIEasyPrint.Models.DeliverOptions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("homeDeliveryPrice")
                        .HasColumnType("float");

                    b.Property<bool>("isHomeDelivery")
                        .HasColumnType("bit");

                    b.Property<bool>("isMailDelivery")
                        .HasColumnType("bit");

                    b.Property<bool>("isPickUp")
                        .HasColumnType("bit");

                    b.Property<double>("mailDeliveryPrice")
                        .HasColumnType("float");

                    b.Property<double>("pickUpPrice")
                        .HasColumnType("float");

                    b.Property<Guid>("printingShopId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("printingShopId")
                        .IsUnique();

                    b.ToTable("deliverOptions");
                });

            modelBuilder.Entity("APIEasyPrint.Models.DeliveryDriver", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("printingShopprentingShopId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("printingShopprentingShopId");

                    b.ToTable("deliveryDrivers");
                });

            modelBuilder.Entity("APIEasyPrint.Models.Document", b =>
                {
                    b.Property<Guid>("docId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("docLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("docTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<byte[]>("fileBytes")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("fileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("size")
                        .HasColumnType("float");

                    b.HasKey("docId");

                    b.HasIndex("CustomerId");

                    b.ToTable("documents");
                });

            modelBuilder.Entity("APIEasyPrint.Models.Feedback", b =>
                {
                    b.Property<Guid>("feedBackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("feedBackDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("feedBackDescription")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("feedBackRate")
                        .HasColumnType("int");

                    b.Property<Guid>("orderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("feedBackId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("orderId");

                    b.ToTable("feedbacks");
                });

            modelBuilder.Entity("APIEasyPrint.Models.Images", b =>
                {
                    b.Property<Guid>("ImgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("ImgeBytes")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ItemId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("siz")
                        .HasColumnType("float");

                    b.HasKey("ImgId");

                    b.ToTable("images");
                });

            modelBuilder.Entity("APIEasyPrint.Models.Item", b =>
                {
                    b.Property<Guid>("itemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("courceMaterialId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("docId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("documentdocId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("isCourceMaterial")
                        .HasColumnType("bit");

                    b.Property<bool>("isPrintingOrder")
                        .HasColumnType("bit");

                    b.Property<Guid>("orderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("printingShopId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("totalPriceOfTheItem")
                        .HasColumnType("float");

                    b.HasKey("itemId");

                    b.HasIndex("courceMaterialId");

                    b.HasIndex("documentdocId");

                    b.HasIndex("orderId");

                    b.HasIndex("printingShopId");

                    b.ToTable("items");
                });

            modelBuilder.Entity("APIEasyPrint.Models.Order", b =>
                {
                    b.Property<Guid>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DeliveryDriverId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("deliveryStatusStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("numberOfItems")
                        .HasColumnType("int");

                    b.Property<DateTime>("orderCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("orderEndDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("orderStatusStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("total")
                        .HasColumnType("float");

                    b.HasKey("orderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DeliveryDriverId");

                    b.HasIndex("deliveryStatusStatusId");

                    b.HasIndex("orderStatusStatusId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("APIEasyPrint.Models.PrintingShop", b =>
                {
                    b.Property<Guid>("prentingShopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PrintingShopEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("addressUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("applicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("commrecialName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isCourseMaterial")
                        .HasColumnType("bit");

                    b.Property<bool>("isService")
                        .HasColumnType("bit");

                    b.Property<Guid?>("orderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ownerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("prentingShopId");

                    b.HasIndex("addressUserId");

                    b.HasIndex("applicationUserId");

                    b.HasIndex("orderId");

                    b.ToTable("printingShops");
                });

            modelBuilder.Entity("APIEasyPrint.Models.PrivatePromotionCode", b =>
                {
                    b.Property<Guid>("privatePromotionCodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("expireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isExpired")
                        .HasColumnType("bit");

                    b.Property<bool>("isUsed")
                        .HasColumnType("bit");

                    b.Property<Guid>("printingShopId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("privatePromotionCodeString")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.HasKey("privatePromotionCodeId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("printingShopId");

                    b.ToTable("privatePromotionCodes");
                });

            modelBuilder.Entity("APIEasyPrint.Models.ProblemReports", b =>
                {
                    b.Property<Guid>("problemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PrintingShopId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("adminId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("problemDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("problemDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("problemTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("problemId");

                    b.HasIndex("PrintingShopId");

                    b.HasIndex("adminId");

                    b.ToTable("problemReports");
                });

            modelBuilder.Entity("APIEasyPrint.Models.PublicPromotionCode", b =>
                {
                    b.Property<Guid>("publicPromotionCodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("expireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isExpired")
                        .HasColumnType("bit");

                    b.Property<Guid>("printingShopId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("publicPromotionCodeString")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.HasKey("publicPromotionCodeId");

                    b.HasIndex("printingShopId");

                    b.ToTable("publicPromotionCodes");
                });

            modelBuilder.Entity("APIEasyPrint.Models.SellUnit", b =>
                {
                    b.Property<Guid>("sellUnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("minimumNumber")
                        .HasColumnType("int")
                        .HasMaxLength(200);

                    b.Property<string>("sellUnitName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("sellUnitId");

                    b.ToTable("sellUnits");
                });

            modelBuilder.Entity("APIEasyPrint.Models.Service", b =>
                {
                    b.Property<Guid>("serviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<Guid>("SellUnitsellUnitId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ServiceDetailsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("printingShopId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("serviceDescreption")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("serviceTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("serviceId");

                    b.HasIndex("ServiceDetailsId");

                    b.ToTable("services");
                });

            modelBuilder.Entity("APIEasyPrint.Models.ServiceDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("ServicePrice")
                        .HasColumnType("float");

                    b.Property<Guid?>("itemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("printingShopId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("selectedServiceserviceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("itemId");

                    b.HasIndex("printingShopId");

                    b.HasIndex("selectedServiceserviceId");

                    b.ToTable("serviceDetails");
                });

            modelBuilder.Entity("APIEasyPrint.Models.Status", b =>
                {
                    b.Property<Guid>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("statusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("statuses");
                });

            modelBuilder.Entity("APIEasyPrint.Models.Subject", b =>
                {
                    b.Property<Guid>("subjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("subjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("subjectId");

                    b.ToTable("subjects");
                });

            modelBuilder.Entity("APIEasyPrint.Models.Suggestion", b =>
                {
                    b.Property<Guid>("suggestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("adminId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("suggestionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("suggestionDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("suggestionTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("suggestionId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("adminId");

                    b.ToTable("suggestions");
                });

            modelBuilder.Entity("APIEasyPrint.Models.CheckoutDetailes", b =>
                {
                    b.HasOne("APIEasyPrint.Models.Order", "order")
                        .WithMany()
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APIEasyPrint.Models.CourceMaterial", b =>
                {
                    b.HasOne("APIEasyPrint.Models.Subject", "courceMaterialSelectedSubject")
                        .WithMany("courceMaterials")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APIEasyPrint.Models.PrintingShop", "printingShop")
                        .WithMany("courceMaterial")
                        .HasForeignKey("printingShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APIEasyPrint.Models.DeliverOptions", b =>
                {
                    b.HasOne("APIEasyPrint.Models.PrintingShop", "printingShop")
                        .WithOne("deliverOptions")
                        .HasForeignKey("APIEasyPrint.Models.DeliverOptions", "printingShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APIEasyPrint.Models.DeliveryDriver", b =>
                {
                    b.HasOne("APIEasyPrint.Models.PrintingShop", "printingShop")
                        .WithMany("deliveryDrivers")
                        .HasForeignKey("printingShopprentingShopId");
                });

            modelBuilder.Entity("APIEasyPrint.Models.Document", b =>
                {
                    b.HasOne("APIEasyPrint.Models.Customer", "customer")
                        .WithMany("documents")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APIEasyPrint.Models.Feedback", b =>
                {
                    b.HasOne("APIEasyPrint.Models.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APIEasyPrint.Models.Order", "order")
                        .WithMany()
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APIEasyPrint.Models.Item", b =>
                {
                    b.HasOne("APIEasyPrint.Models.CourceMaterial", "courceMaterial")
                        .WithMany()
                        .HasForeignKey("courceMaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APIEasyPrint.Models.Document", "document")
                        .WithMany()
                        .HasForeignKey("documentdocId");

                    b.HasOne("APIEasyPrint.Models.Order", "order")
                        .WithMany("items")
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APIEasyPrint.Models.PrintingShop", "printingShop")
                        .WithMany()
                        .HasForeignKey("printingShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APIEasyPrint.Models.Order", b =>
                {
                    b.HasOne("APIEasyPrint.Models.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APIEasyPrint.Models.DeliveryDriver", null)
                        .WithMany("orders")
                        .HasForeignKey("DeliveryDriverId");

                    b.HasOne("APIEasyPrint.Models.Status", "deliveryStatus")
                        .WithMany()
                        .HasForeignKey("deliveryStatusStatusId");

                    b.HasOne("APIEasyPrint.Models.Status", "orderStatus")
                        .WithMany()
                        .HasForeignKey("orderStatusStatusId");
                });

            modelBuilder.Entity("APIEasyPrint.Models.PrintingShop", b =>
                {
                    b.HasOne("APIEasyPrint.Models.Address", "address")
                        .WithMany()
                        .HasForeignKey("addressUserId");

                    b.HasOne("APIEasyPrint.Models.ApplicationUser", "applicationUser")
                        .WithMany()
                        .HasForeignKey("applicationUserId");

                    b.HasOne("APIEasyPrint.Models.Order", null)
                        .WithMany("printingShops")
                        .HasForeignKey("orderId");
                });

            modelBuilder.Entity("APIEasyPrint.Models.PrivatePromotionCode", b =>
                {
                    b.HasOne("APIEasyPrint.Models.Customer", "customer")
                        .WithMany("privatePromotionCodes")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APIEasyPrint.Models.PrintingShop", "printingShop")
                        .WithMany("privatePromotionCodes")
                        .HasForeignKey("printingShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APIEasyPrint.Models.ProblemReports", b =>
                {
                    b.HasOne("APIEasyPrint.Models.PrintingShop", "printingShop")
                        .WithMany("problemReports")
                        .HasForeignKey("PrintingShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APIEasyPrint.Models.Admin", "admin")
                        .WithMany("problemReports")
                        .HasForeignKey("adminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APIEasyPrint.Models.PublicPromotionCode", b =>
                {
                    b.HasOne("APIEasyPrint.Models.PrintingShop", "printingShop")
                        .WithMany("publicPromotionCodes")
                        .HasForeignKey("printingShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APIEasyPrint.Models.Service", b =>
                {
                    b.HasOne("APIEasyPrint.Models.ServiceDetails", null)
                        .WithMany("services")
                        .HasForeignKey("ServiceDetailsId");
                });

            modelBuilder.Entity("APIEasyPrint.Models.ServiceDetails", b =>
                {
                    b.HasOne("APIEasyPrint.Models.Item", null)
                        .WithMany("services")
                        .HasForeignKey("itemId");

                    b.HasOne("APIEasyPrint.Models.PrintingShop", "printingShop")
                        .WithMany("serviceDetails")
                        .HasForeignKey("printingShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APIEasyPrint.Models.Service", "selectedService")
                        .WithMany()
                        .HasForeignKey("selectedServiceserviceId");
                });

            modelBuilder.Entity("APIEasyPrint.Models.Suggestion", b =>
                {
                    b.HasOne("APIEasyPrint.Models.Customer", "customer")
                        .WithMany("suggestions")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APIEasyPrint.Models.Admin", "admin")
                        .WithMany("suggestions")
                        .HasForeignKey("adminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
