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
    [Migration("20210202215821_CloudTest")]
    partial class CloudTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EasyPrintWebSite.Models.Address", b =>
                {
                    b.Property<Guid>("invoiceId")
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

                    b.HasKey("invoiceId");

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.Admin", b =>
                {
                    b.Property<Guid>("invoiceId")
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

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasKey("invoiceId");

                    b.ToTable("admins");
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.ApplicationUser", b =>
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

            modelBuilder.Entity("EasyPrintWebSite.Models.CheckoutDetailes", b =>
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

            modelBuilder.Entity("EasyPrintWebSite.Models.CourceMaterial", b =>
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

            modelBuilder.Entity("EasyPrintWebSite.Models.Customer", b =>
                {
                    b.Property<Guid>("invoiceId")
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

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasKey("invoiceId");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.DeliverOptions", b =>
                {
                    b.Property<Guid>("invoiceId")
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

                    b.HasKey("invoiceId");

                    b.HasIndex("printingShopId")
                        .IsUnique();

                    b.ToTable("deliverOptions");
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.DeliveryDriver", b =>
                {
                    b.Property<Guid>("invoiceId")
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

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasKey("invoiceId");

                    b.HasIndex("printingShopprentingShopId");

                    b.ToTable("deliveryDrivers");
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.Document", b =>
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

                    b.HasKey("docId");

                    b.HasIndex("CustomerId");

                    b.ToTable("documents");
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.Feedback", b =>
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

            modelBuilder.Entity("EasyPrintWebSite.Models.Item", b =>
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

            modelBuilder.Entity("EasyPrintWebSite.Models.Order", b =>
                {
                    b.Property<Guid>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DeliveryDriverinvoiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("deliveryStatusStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("numberOfItems")
                        .HasColumnType("int");

                    b.Property<Guid?>("orderStatusStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("total")
                        .HasColumnType("float");

                    b.HasKey("orderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DeliveryDriverinvoiceId");

                    b.HasIndex("deliveryStatusStatusId");

                    b.HasIndex("orderStatusStatusId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.PrintingShop", b =>
                {
                    b.Property<Guid>("prentingShopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("addressinvoiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("applicationUserId")
                        .HasColumnType("nvarchar(450)");

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

                    b.HasIndex("addressinvoiceId");

                    b.HasIndex("applicationUserId");

                    b.HasIndex("orderId");

                    b.ToTable("printingShops");
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.PrivatePromotionCode", b =>
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

            modelBuilder.Entity("EasyPrintWebSite.Models.ProblemReports", b =>
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

            modelBuilder.Entity("EasyPrintWebSite.Models.PublicPromotionCode", b =>
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

            modelBuilder.Entity("EasyPrintWebSite.Models.SellUnit", b =>
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

                    b.Property<Guid?>("serviceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("sellUnitId");

                    b.HasIndex("serviceId");

                    b.ToTable("sellUnits");
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.Service", b =>
                {
                    b.Property<Guid>("serviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ServiceDetailsinvoiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("selectedSellUnitsellUnitId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("serviceDescreption")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("serviceTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("serviceId");

                    b.HasIndex("ServiceDetailsinvoiceId");

                    b.HasIndex("selectedSellUnitsellUnitId");

                    b.ToTable("services");
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.ServiceDetails", b =>
                {
                    b.Property<Guid>("invoiceId")
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

                    b.HasKey("invoiceId");

                    b.HasIndex("itemId");

                    b.HasIndex("printingShopId");

                    b.HasIndex("selectedServiceserviceId");

                    b.ToTable("serviceDetails");
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.Status", b =>
                {
                    b.Property<Guid>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("statusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("statuses");
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.Subject", b =>
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

            modelBuilder.Entity("EasyPrintWebSite.Models.Suggestion", b =>
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

            modelBuilder.Entity("EasyPrintWebSite.Models.CheckoutDetailes", b =>
                {
                    b.HasOne("EasyPrintWebSite.Models.Order", "order")
                        .WithMany()
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.CourceMaterial", b =>
                {
                    b.HasOne("EasyPrintWebSite.Models.Subject", "courceMaterialSelectedSubject")
                        .WithMany("courceMaterials")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyPrintWebSite.Models.PrintingShop", "printingShop")
                        .WithMany("courceMaterial")
                        .HasForeignKey("printingShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.DeliverOptions", b =>
                {
                    b.HasOne("EasyPrintWebSite.Models.PrintingShop", "printingShop")
                        .WithOne("deliverOptions")
                        .HasForeignKey("EasyPrintWebSite.Models.DeliverOptions", "printingShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.DeliveryDriver", b =>
                {
                    b.HasOne("EasyPrintWebSite.Models.PrintingShop", "printingShop")
                        .WithMany("deliveryDrivers")
                        .HasForeignKey("printingShopprentingShopId");
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.Document", b =>
                {
                    b.HasOne("EasyPrintWebSite.Models.Customer", "customer")
                        .WithMany("documents")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.Feedback", b =>
                {
                    b.HasOne("EasyPrintWebSite.Models.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyPrintWebSite.Models.Order", "order")
                        .WithMany()
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.Item", b =>
                {
                    b.HasOne("EasyPrintWebSite.Models.CourceMaterial", "courceMaterial")
                        .WithMany()
                        .HasForeignKey("courceMaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyPrintWebSite.Models.Document", "document")
                        .WithMany()
                        .HasForeignKey("documentdocId");

                    b.HasOne("EasyPrintWebSite.Models.Order", "order")
                        .WithMany("items")
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyPrintWebSite.Models.PrintingShop", "printingShop")
                        .WithMany()
                        .HasForeignKey("printingShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.Order", b =>
                {
                    b.HasOne("EasyPrintWebSite.Models.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyPrintWebSite.Models.DeliveryDriver", null)
                        .WithMany("orders")
                        .HasForeignKey("DeliveryDriverinvoiceId");

                    b.HasOne("EasyPrintWebSite.Models.Status", "deliveryStatus")
                        .WithMany()
                        .HasForeignKey("deliveryStatusStatusId");

                    b.HasOne("EasyPrintWebSite.Models.Status", "orderStatus")
                        .WithMany()
                        .HasForeignKey("orderStatusStatusId");
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.PrintingShop", b =>
                {
                    b.HasOne("EasyPrintWebSite.Models.Address", "address")
                        .WithMany()
                        .HasForeignKey("addressinvoiceId");

                    b.HasOne("EasyPrintWebSite.Models.ApplicationUser", "applicationUser")
                        .WithMany()
                        .HasForeignKey("applicationUserId");

                    b.HasOne("EasyPrintWebSite.Models.Order", null)
                        .WithMany("printingShops")
                        .HasForeignKey("orderId");
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.PrivatePromotionCode", b =>
                {
                    b.HasOne("EasyPrintWebSite.Models.Customer", "customer")
                        .WithMany("privatePromotionCodes")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyPrintWebSite.Models.PrintingShop", "printingShop")
                        .WithMany("privatePromotionCodes")
                        .HasForeignKey("printingShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.ProblemReports", b =>
                {
                    b.HasOne("EasyPrintWebSite.Models.PrintingShop", "printingShop")
                        .WithMany("problemReports")
                        .HasForeignKey("PrintingShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyPrintWebSite.Models.Admin", "admin")
                        .WithMany("problemReports")
                        .HasForeignKey("adminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.PublicPromotionCode", b =>
                {
                    b.HasOne("EasyPrintWebSite.Models.PrintingShop", "printingShop")
                        .WithMany("publicPromotionCodes")
                        .HasForeignKey("printingShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.SellUnit", b =>
                {
                    b.HasOne("EasyPrintWebSite.Models.Service", null)
                        .WithMany("allSellUnits")
                        .HasForeignKey("serviceId");
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.Service", b =>
                {
                    b.HasOne("EasyPrintWebSite.Models.ServiceDetails", null)
                        .WithMany("services")
                        .HasForeignKey("ServiceDetailsinvoiceId");

                    b.HasOne("EasyPrintWebSite.Models.SellUnit", "selectedSellUnit")
                        .WithMany()
                        .HasForeignKey("selectedSellUnitsellUnitId");
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.ServiceDetails", b =>
                {
                    b.HasOne("EasyPrintWebSite.Models.Item", null)
                        .WithMany("services")
                        .HasForeignKey("itemId");

                    b.HasOne("EasyPrintWebSite.Models.PrintingShop", "printingShop")
                        .WithMany("serviceDetails")
                        .HasForeignKey("printingShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyPrintWebSite.Models.Service", "selectedService")
                        .WithMany()
                        .HasForeignKey("selectedServiceserviceId");
                });

            modelBuilder.Entity("EasyPrintWebSite.Models.Suggestion", b =>
                {
                    b.HasOne("EasyPrintWebSite.Models.Customer", "customer")
                        .WithMany("suggestions")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyPrintWebSite.Models.Admin", "admin")
                        .WithMany("suggestions")
                        .HasForeignKey("adminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
