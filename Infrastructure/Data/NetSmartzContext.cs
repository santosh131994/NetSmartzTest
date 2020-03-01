using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetSmartz.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetSmartz.Infrastructure.Data
{
    public class NetSmartzContext:DbContext
    {
        public NetSmartzContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Product>(ConfigureProduct);
        //    builder.Entity<Category>(ConfigureCategory);
        //}

        //private void ConfigureProduct(EntityTypeBuilder<Product> builder)
        //{
        //    builder.ToTable("Product");

        //    builder.HasKey(ci => ci.ProductId);


        //    builder.Property(cb => cb.Name)
        //        .IsRequired()
        //        .HasMaxLength(100);
        //}

        //private void ConfigureCategory(EntityTypeBuilder<Category> builder)
        //{
        //    builder.ToTable("Category");
        //    builder.Property(cb => cb.Name)
        //        .IsRequired()
        //        .HasMaxLength(100);
        //}

    }
}
