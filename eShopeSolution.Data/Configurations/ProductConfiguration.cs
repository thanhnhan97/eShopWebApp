﻿using eShopeSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopeSolution.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //Render sang SQL
            builder.ToTable("Products");

            //Set primary key
            builder.HasKey(x => x.ID);

            builder.Property(x => x.Price).IsRequired();

            builder.Property(x => x.OriginalPrice).IsRequired();

            builder.Property(x => x.Stock).IsRequired().HasDefaultValue<int>(0);

            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue<int>(0);

        }
    }
}
