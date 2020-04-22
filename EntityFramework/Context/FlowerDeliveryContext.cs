using Microsoft.EntityFrameworkCore;
using Model;

namespace EntityFramework.Context
{
    public class FlowerDeliveryContext : DbContext
    {
        public FlowerDeliveryContext(DbContextOptions<FlowerDeliveryContext> options)
           : base(options)
        { }

        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Plantation> Plantations { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Supply> Supplies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlantationFlower>()
                .HasKey(pf => new { pf.PlantationId, pf.FlowerId });
            modelBuilder.Entity<PlantationFlower>()
                .HasOne(pf => pf.Plantation)
                .WithMany(p => p.PlantationFlowers)
                .HasForeignKey(pf => pf.PlantationId);
            modelBuilder.Entity<PlantationFlower>()
                .HasOne(pf => pf.Flower)
                .WithMany(f => f.PlantationFlowers)
                .HasForeignKey(pf => pf.FlowerId);

            modelBuilder.Entity<SupplyFlower>()
                 .HasKey(sf => new { sf.SupplyId, sf.FlowerId });
            modelBuilder.Entity<SupplyFlower>()
                .HasOne(sf => sf.Supply)
                .WithMany(s => s.SupplyFlowers)
                .HasForeignKey(sf => sf.SupplyId);
            modelBuilder.Entity<SupplyFlower>()
                .HasOne(sf => sf.Flower)
                .WithMany(f => f.SupplyFlowers)
                .HasForeignKey(sf => sf.FlowerId);

            modelBuilder.Entity<WarehouseFlower>()
                .HasKey(wf => new { wf.WarehouseId, wf.FlowerId });
            modelBuilder.Entity<WarehouseFlower>()
                .HasOne(wf => wf.Warehouse)
                .WithMany(w => w.WarehouseFlowers)
                .HasForeignKey(wf => wf.WarehouseId);
            modelBuilder.Entity<WarehouseFlower>()
                .HasOne(wf => wf.Flower)
                .WithMany(f => f.WarehouseFlowers)
                .HasForeignKey(wf => wf.FlowerId);
        }
    }
}
