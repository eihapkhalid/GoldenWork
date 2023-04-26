using System;
using System.Collections.Generic;
using Domains;
using Microsoft.EntityFrameworkCore;

//identity AspNetCore Step 1 :install NuGet : Microsoft.AspNetCore.Identity.EntityFrameworkCore
//identity AspNetCore Step  2 : and replace dbContext with = IdentityDbContext<IdentityUser>
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Bl;

public partial class FireSystemContractsDbContext : IdentityDbContext<IdentityUser>
{
    public FireSystemContractsDbContext()
    {
    }

    public FireSystemContractsDbContext(DbContextOptions<FireSystemContractsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbContract> TbContracts { get; set; }

    public virtual DbSet<TbContractItem> TbContractItems { get; set; }

    public virtual DbSet<TbItemsc> TbItemscs { get; set; }

    public virtual DbSet<TbMaintenanceItem> TbMaintenanceItems { get; set; }

    public virtual DbSet<TbMaintenanceService> TbMaintenanceServices { get; set; }

    public virtual DbSet<TbMaintenanceServicesItem> TbMaintenanceServicesItems { get; set; }

    public virtual DbSet<VwContractMaintnceService> VwContractMaintnceServices { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
		//optionsBuilder.UseSqlServer("Server =DESKTOP-IBHOD3E;Database=FireSystemContractsDB; Trusted_Connection=True;Encrypt=False;");
	}


	protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //identity AspNetCore Step 4 : add OnModelCreating

        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<TbContract>(entity =>
        {
            entity.HasKey(e => e.ContractId);

            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.ContractDate).HasColumnType("date");
            entity.Property(e => e.ContractType).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FirstParty).HasMaxLength(100);
            entity.Property(e => e.MaintenanceId).HasColumnName("MaintenanceID");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SecondParty).HasMaxLength(100);

            entity.HasOne(d => d.Maintenance).WithMany(p => p.TbContracts)
                .HasForeignKey(d => d.MaintenanceId)
                .HasConstraintName("FK_TbContracts_TbMaintenanceServices");
        });

        modelBuilder.Entity<TbContractItem>(entity =>
        {
            entity.HasKey(e => e.ContractItemsId).HasName("PK_TbContractItems_1");

            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");

            entity.HasOne(d => d.Contract).WithMany(p => p.TbContractItems)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbContractItems_TbContracts1");

            entity.HasOne(d => d.Item).WithMany(p => p.TbContractItems)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbContractItems_TbItemsc");
        });

        modelBuilder.Entity<TbItemsc>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK_TbContractItems");

            entity.ToTable("TbItemsc");

            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ItemDescription).HasMaxLength(200);
            entity.Property(e => e.ItemName).HasMaxLength(200);
        });

        modelBuilder.Entity<TbMaintenanceItem>(entity =>
        {
            entity.HasKey(e => e.MaintenanceItemsId);

            entity.Property(e => e.ItemDescription).HasMaxLength(100);
            entity.Property(e => e.ItemName).HasMaxLength(200);
        });

        modelBuilder.Entity<TbMaintenanceService>(entity =>
        {
            entity.HasKey(e => e.MaintenanceId);

            entity.Property(e => e.MaintenanceId).HasColumnName("MaintenanceID");
            entity.Property(e => e.SecondPartyLocation).HasMaxLength(100);
            entity.Property(e => e.ServiceType).HasMaxLength(50);
        });

        modelBuilder.Entity<TbMaintenanceServicesItem>(entity =>
        {
            entity.HasKey(e => e.ServicesItemsId);

            entity.Property(e => e.ServicesItemsId).ValueGeneratedOnAdd();
            entity.Property(e => e.MaintenanceId).HasColumnName("MaintenanceID");

            entity.HasOne(d => d.Maintenance).WithMany(p => p.TbMaintenanceServicesItems)
                .HasForeignKey(d => d.MaintenanceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbMaintenanceServicesItems_TbMaintenanceServices");

            entity.HasOne(d => d.ServicesItems).WithOne(p => p.TbMaintenanceServicesItem)
                .HasForeignKey<TbMaintenanceServicesItem>(d => d.ServicesItemsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbMaintenanceServicesItems_TbMaintenanceItems");
        });

        modelBuilder.Entity<VwContractMaintnceService>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwContractMaintnceServices");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    
}
