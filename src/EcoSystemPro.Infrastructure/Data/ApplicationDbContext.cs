using EcoSystemPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EcoSystemPro.Infrastructure.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Supplier> Suppliers { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Sale> Sales { get; set; }
		public DbSet<SaleDetail> SaleDetails { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}