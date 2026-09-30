using JohnsGarage.Models;
using Microsoft.EntityFrameworkCore;

namespace JohnsGarage.Data;

// Portfolio excerpt only. The production database path, migration helpers,
// customer data, and operational configuration are intentionally excluded.
public class GarageDbContext : DbContext
{
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Vehicle> Vehicles => Set<Vehicle>();
    public DbSet<RepairOrder> RepairOrders => Set<RepairOrder>();
    public DbSet<Part> Parts => Set<Part>();
    public DbSet<LaborItem> LaborItems => Set<LaborItem>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlite("Data Source=JohnsGarage.Demo.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()
            .HasMany(c => c.Vehicles)
            .WithOne(v => v.Customer)
            .HasForeignKey(v => v.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Vehicle>()
            .HasMany(v => v.RepairOrders)
            .WithOne(ro => ro.Vehicle)
            .HasForeignKey(ro => ro.VehicleId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<RepairOrder>()
            .HasMany(ro => ro.Parts)
            .WithOne(p => p.RepairOrder)
            .HasForeignKey(p => p.RepairOrderId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<RepairOrder>()
            .HasMany(ro => ro.LaborItems)
            .WithOne(l => l.RepairOrder)
            .HasForeignKey(l => l.RepairOrderId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
