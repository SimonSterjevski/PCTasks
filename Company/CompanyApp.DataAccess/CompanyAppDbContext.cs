using CompanyApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.DataAccess
{
    public class CompanyAppDbContext: DbContext
    {
        public CompanyAppDbContext()
        {

        }
        public CompanyAppDbContext(DbContextOptions options): base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        public DbSet<Store> Stores { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<SuplyActivity> Deliveries { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SuplyActivity>()
                .HasOne(x => x.Store);
            modelBuilder.Entity<SuplyActivity>()
                .HasOne(x => x.Warehouse);
            modelBuilder.Entity<SuplyActivity>()
               .HasOne(x => x.Product);
            modelBuilder.Entity<Warehouse>()
                .HasMany(x => x.Deliveries)
                .WithOne(x => x.Warehouse)
                .HasForeignKey(x => x.WarehouseId);
            modelBuilder.Entity<Warehouse>()
                .HasMany(x => x.WarehouseItems)
                .WithOne(x => x.Warehouse)
                .HasForeignKey(x => x.WarehouseId);
            modelBuilder.Entity<Store>()
                .HasMany(x => x.StoreItems)
                .WithOne(x => x.Store)
                .HasForeignKey(x => x.StoreId);

            //seed
            modelBuilder.Entity<Warehouse>()
                .HasData(new Warehouse
                {
                    Id = 1,
                    Name = "FinishedGoods1",
                    Phone = 111222333,
                }, new Warehouse
                {
                    Id = 2,
                    Name = "FinishedGoods2",
                    Phone = 111222334,
                }
                );
            modelBuilder.Entity<WarehouseItem>()
                .HasData(new WarehouseItem
                {
                    Id = 1,
                    Quantity = 50,
                    ProductId = 1,
                    WarehouseId = 1
                },
                new WarehouseItem
                {
                    Id = 2,
                    Quantity = 50,
                    ProductId = 1,
                    WarehouseId = 2
                }
                );
            modelBuilder.Entity<Store>()
                .HasData(new Store
                {
                    Id = 1,
                    Location = "Karpos4",
                    Manager = "Nino Ninov",
                    Size = 55,
                    StoreType = Domain.Enums.StoreType.Supermarket
                }
                );
            modelBuilder.Entity<Product>()
              .HasData(new Product
              {
                  Id = 1,
                  Name = "Shoes",
                  Quantity = 100
              }
              );
        }

       
    }
}
