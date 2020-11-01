using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rewards.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Infra.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasMany(c => c.Products)
                .WithOne(c => c.Category);
        }
    }
}
