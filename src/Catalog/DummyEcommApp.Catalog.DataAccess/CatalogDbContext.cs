using DummyEcommApp.Catalog.DataAccess.ModelConfiguration;
using DummyEcommApp.Catalog.Models;
using Microsoft.EntityFrameworkCore;

namespace DummyEcommApp.Catalog.DataAccess
{
	public class CatalogDbContext : DbContext
	{
		public CatalogDbContext(DbContextOptions<CatalogDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyCatalogConfigurations();
			base.OnModelCreating(modelBuilder);
		}

		protected DbSet<Product> Products { get; set; }

		protected DbSet<Category> Categories { get; set; }

		protected DbSet<ProductItem> ProductItems { get; set; }
	}
}
