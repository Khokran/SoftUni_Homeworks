﻿namespace P03_SalesDatabase.Data
{
    using P03_SalesDatabase.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Migrations;

    public class SalesContext : DbContext
    {
        public SalesContext()
        {

        }

        public SalesContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Store> Stores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.ProductId);

                entity.Property(p => p.Name)
                      .HasMaxLength(50)
                      .IsRequired(true)
                      .IsUnicode(true);

                entity.Property(p => p.Description)
                      .HasMaxLength(250)
                      .IsRequired(false)
                      .IsUnicode(true)
                      .HasDefaultValue("No description");

                entity.Property(p => p.Quantity)
                      .IsRequired(true);

                entity.Property(p => p.Price)
                      .IsRequired(true);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(p => p.CustomerId);

                entity.Property(p => p.Name)
                      .HasMaxLength(100)
                      .IsRequired(true)
                      .IsUnicode(true);

                entity.Property(p => p.Email)
                      .HasMaxLength(80)
                      .IsRequired(true)
                      .IsUnicode(false);

                entity.Property(p => p.CreditCardNumber)
                      .IsRequired(true)
                      .IsUnicode(false);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasKey(p => p.StoreId);

                entity.Property(p => p.Name)
                      .HasMaxLength(80)
                      .IsRequired(true)
                      .IsUnicode(true);
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasKey(s => s.SaleId);

                entity.Property(s => s.Date)
                      .IsRequired(true)
                      .HasColumnName("DATETIME2")
                      .HasDefaultValueSql("GETDATE()");

                entity.HasOne(s => s.Product)
                      .WithMany(p => p.Sales)
                      .HasForeignKey(s => s.ProductId);

                entity.HasOne(s => s.Customer)
                      .WithMany(c => c.Sales)
                      .HasForeignKey(s => s.CustomerId);

                entity.HasOne(s => s.Store)
                      .WithMany(st => st.Sales)
                      .HasForeignKey(s => s.StoreId);
            });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");
        }

    }
}
