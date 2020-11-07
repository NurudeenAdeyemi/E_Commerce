using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>(o =>
            {
                o.HasIndex(o => new { o.ProductId, o.OrderId }).IsUnique();
            });

            modelBuilder.Entity<BrandCategory>(o =>
            {
                o.HasIndex(o => new { o.BrandId, o.CategoryId }).IsUnique();
            });

            modelBuilder.Entity<ProductBrand>(o =>
            {
                o.HasIndex(o => new { o.ProductId, o.BrandId }).IsUnique();
            });

           

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Category> Categories { get; set; }
       
        public DbSet<OrderProduct> OrderProducts{ get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<ProductBrand> ProductBrands { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<BrandCategory> BrandCategories { get; set; }

    }
}

