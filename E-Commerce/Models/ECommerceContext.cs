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

            modelBuilder.Entity<SubCategoryBrand>(o =>
            {
                o.HasIndex(o => new { o.BrandId, o.SubCategoryId }).IsUnique();
            });

            modelBuilder.Entity<CategorySubCategory>(o =>
            {
                o.HasIndex(o => new { o.CategoryId, o.SubCategoryId }).IsUnique();
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

        public DbSet<SubCategoryBrand> SubCategoryBrands { get; set; }

        public DbSet<CategorySubCategory> CategorySubCategories { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }

    }
}

