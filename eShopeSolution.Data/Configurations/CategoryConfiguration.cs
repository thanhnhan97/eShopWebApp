﻿using eShopeSolution.Data.Entities;
using eShopeSolution.Data.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopeSolution.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID).UseIdentityColumn();


            builder.Property(x => x.Status).HasDefaultValue(Status.Active);

        }
    }
}
