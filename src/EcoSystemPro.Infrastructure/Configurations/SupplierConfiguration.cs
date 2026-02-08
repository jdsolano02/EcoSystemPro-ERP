using EcoSystemPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcoSystemPro.Infrastructure.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(s => s.Email)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasIndex(s => s.Email).IsUnique();

            builder.Property(s => s.PhoneNumber)
                .HasMaxLength(20)
                .IsRequired();


            builder.HasMany(s => s.Products)
                   .WithOne(p => p.Supplier)
                   .HasForeignKey(p => p.SupplierId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}