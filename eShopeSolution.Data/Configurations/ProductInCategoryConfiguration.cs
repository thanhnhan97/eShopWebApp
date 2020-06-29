using eShopeSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopeSolution.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(x => new { x.CategoryID, x.ProductID });

            builder.ToTable("ProductInCategory");

            //Quan he many to many
            //Khoa ngoai cho Product, lien ket thong qua ProductInCategory
            builder.HasOne(x => x.Product).WithMany(y => y.ProductInCategories)
                    .HasForeignKey(y => y.ProductID);

            //Khoa ngoai cho Category
            builder.HasOne(x => x.Category).WithMany(y => y.ProductInCategories)
                    .HasForeignKey(y => y.CategoryID);
        }
    }
}
