﻿// <auto-generated />
using System;
using Bl;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bl.Migrations
{
    [DbContext(typeof(FireSystemContractsDbContext))]
    [Migration("20230408073911_VwContractMaintnceServices")]
    partial class VwContractMaintnceServices
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bl.TbContract", b =>
                {
                    b.Property<int>("ContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ContractID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContractId"));

                    b.Property<DateTime>("ContractDate")
                        .HasColumnType("date");

                    b.Property<string>("ContractType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("FirstParty")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("MaintenanceId")
                        .HasColumnType("int")
                        .HasColumnName("MaintenanceID");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("SecondParty")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ContractId");

                    b.HasIndex("MaintenanceId");

                    b.ToTable("TbContracts");
                });

            modelBuilder.Entity("Bl.TbContractItem", b =>
                {
                    b.Property<int>("ContractItemsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContractItemsId"));

                    b.Property<int>("ContractId")
                        .HasColumnType("int")
                        .HasColumnName("ContractID");

                    b.Property<int>("ItemId")
                        .HasColumnType("int")
                        .HasColumnName("ItemID");

                    b.HasKey("ContractItemsId")
                        .HasName("PK_TbContractItems_1");

                    b.HasIndex("ContractId");

                    b.HasIndex("ItemId");

                    b.ToTable("TbContractItems");
                });

            modelBuilder.Entity("Bl.TbItemsc", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ItemID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<string>("ItemDescription")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ItemId")
                        .HasName("PK_TbContractItems");

                    b.ToTable("TbItemsc", (string)null);
                });

            modelBuilder.Entity("Bl.TbMaintenanceItem", b =>
                {
                    b.Property<int>("MaintenanceItemsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaintenanceItemsId"));

                    b.Property<string>("ItemDescription")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("MaintenanceItemsId");

                    b.ToTable("TbMaintenanceItems");
                });

            modelBuilder.Entity("Bl.TbMaintenanceService", b =>
                {
                    b.Property<int>("MaintenanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaintenanceID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaintenanceId"));

                    b.Property<string>("SecondPartyLocation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ServiceType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaintenanceId");

                    b.ToTable("TbMaintenanceServices");
                });

            modelBuilder.Entity("Bl.TbMaintenanceServicesItem", b =>
                {
                    b.Property<int>("ServicesItemsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MaintenanceId")
                        .HasColumnType("int")
                        .HasColumnName("MaintenanceID");

                    b.Property<int>("MaintenanceItemsId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ServicesItemsId");

                    b.HasIndex("MaintenanceId");

                    b.ToTable("TbMaintenanceServicesItems");
                });

            modelBuilder.Entity("Bl.View1", b =>
                {
                    b.Property<DateTime>("ContractDate")
                        .HasColumnType("date");

                    b.Property<int>("ContractId")
                        .HasColumnType("int")
                        .HasColumnName("ContractID");

                    b.Property<string>("ContractType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("FirstParty")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SecondParty")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.ToTable((string)null);

                    b.ToView("View_1", (string)null);
                });

            modelBuilder.Entity("Domains.VwContractMaintnceService", b =>
                {
                    b.Property<DateTime>("ContractDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<string>("ContractType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstParty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("SecondParty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondPartyLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable((string)null);

                    b.ToView("VwContractMaintnceServices", (string)null);
                });

            modelBuilder.Entity("Bl.TbContract", b =>
                {
                    b.HasOne("Bl.TbMaintenanceService", "Maintenance")
                        .WithMany("TbContracts")
                        .HasForeignKey("MaintenanceId")
                        .HasConstraintName("FK_TbContracts_TbMaintenanceServices");

                    b.Navigation("Maintenance");
                });

            modelBuilder.Entity("Bl.TbContractItem", b =>
                {
                    b.HasOne("Bl.TbContract", "Contract")
                        .WithMany("TbContractItems")
                        .HasForeignKey("ContractId")
                        .IsRequired()
                        .HasConstraintName("FK_TbContractItems_TbContracts1");

                    b.HasOne("Bl.TbItemsc", "Item")
                        .WithMany("TbContractItems")
                        .HasForeignKey("ItemId")
                        .IsRequired()
                        .HasConstraintName("FK_TbContractItems_TbItemsc");

                    b.Navigation("Contract");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Bl.TbMaintenanceServicesItem", b =>
                {
                    b.HasOne("Bl.TbMaintenanceService", "Maintenance")
                        .WithMany("TbMaintenanceServicesItems")
                        .HasForeignKey("MaintenanceId")
                        .IsRequired()
                        .HasConstraintName("FK_TbMaintenanceServicesItems_TbMaintenanceServices");

                    b.HasOne("Bl.TbMaintenanceItem", "ServicesItems")
                        .WithOne("TbMaintenanceServicesItem")
                        .HasForeignKey("Bl.TbMaintenanceServicesItem", "ServicesItemsId")
                        .IsRequired()
                        .HasConstraintName("FK_TbMaintenanceServicesItems_TbMaintenanceItems");

                    b.Navigation("Maintenance");

                    b.Navigation("ServicesItems");
                });

            modelBuilder.Entity("Bl.TbContract", b =>
                {
                    b.Navigation("TbContractItems");
                });

            modelBuilder.Entity("Bl.TbItemsc", b =>
                {
                    b.Navigation("TbContractItems");
                });

            modelBuilder.Entity("Bl.TbMaintenanceItem", b =>
                {
                    b.Navigation("TbMaintenanceServicesItem");
                });

            modelBuilder.Entity("Bl.TbMaintenanceService", b =>
                {
                    b.Navigation("TbContracts");

                    b.Navigation("TbMaintenanceServicesItems");
                });
#pragma warning restore 612, 618
        }
    }
}
