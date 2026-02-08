using EcoSystemPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcoSystemPro.Infrastructure.Configurations
{
    public class SaleDetailConfiguration : IEntityTypeConfiguration<SaleDetail>
    {
        public void Configure(EntityTypeBuilder<SaleDetail> builder)
        {
            builder.HasKey(sd => sd.Id);

            builder.Property(sd => sd.UnitPrice)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.HasOne(sd => sd.Sale)
                .WithMany(s => s.SaleDetails)
                .HasForeignKey(sd => sd.SaleId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(sd => sd.Product)
                .WithMany()
                .HasForeignKey(sd => sd.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}