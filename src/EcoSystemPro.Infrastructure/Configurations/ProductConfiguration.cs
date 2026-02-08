using EcoSystemPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcoSystemPro.Infrastructure.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasMaxLength(100) 
                .IsRequired();

            builder.Property(p => p.Price)
                .HasColumnType("decimal(18,2)") 
                .IsRequired();

            builder.Property(p => p.Stock)
                .IsRequired()
                .HasDefaultValue(0);

            builder.HasOne(p => p.Supplier)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.SupplierId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}