using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProtectiveVehiclemanagementMVC.Data;

public partial class PmvsdbContext : DbContext
{
    public PmvsdbContext(DbContextOptions<PmvsdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.VehicleNum).HasName("PK__Vehicles__1EC1D0991E1053F1");

            entity.Property(e => e.VehicleNum).HasMaxLength(7);
            entity.Property(e => e.DateAdded).HasColumnType("date");
            entity.Property(e => e.VehicleStatus).HasMaxLength(11);
            entity.Property(e => e.VehicleType).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
