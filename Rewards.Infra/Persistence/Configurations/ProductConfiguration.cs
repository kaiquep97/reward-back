using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rewards.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Infra.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Image)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Status)
                .HasConversion(
                v => v.ToString(),
                v => (Core.Enums.ProductStatusEnum)Enum.Parse(typeof(Core.Enums.ProductStatusEnum), v));

            builder.HasOne(c => c.Category)
                .WithMany(c => c.Products);
        }
    }
}
