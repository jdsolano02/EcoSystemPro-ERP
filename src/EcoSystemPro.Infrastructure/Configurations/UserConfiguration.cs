using EcoSystemPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcoSystemPro.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Username)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasIndex(u => u.Username).IsUnique();

            builder.Property(u => u.PasswordHash)
                .IsRequired();

            builder.Property(u => u.Role)
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}