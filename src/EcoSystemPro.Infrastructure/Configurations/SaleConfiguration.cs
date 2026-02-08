using EcoSystemPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcoSystemPro.Infrastructure.Configurations
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(s => s.Id);


            builder.Property(s => s.Total)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.HasOne(s => s.User)
                .WithMany(u => u.Sales)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}