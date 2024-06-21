using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SupplyGoods.Models;

namespace SupplyGoods.DataBase
{
    internal class Context: DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipment> Shipments { get; set; }

        public Context() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql("server=localhost;user=root;password=77777;database=supplygoods_db",
             //                       new MySqlServerVersion(new Version(8, 0, 31)));
            optionsBuilder.UseSqlite("Data Source=D:\\\\database1807.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Product)
                .WithMany(p => p.Orders)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Client)
                .WithMany(c => c.Orders)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Shipment>()
                .HasOne(s => s.Order)
                .WithMany(o => o.Shipments)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
