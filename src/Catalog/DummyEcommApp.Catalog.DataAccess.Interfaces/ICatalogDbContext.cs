using DummyEcommApp.Catalog.Models;
using Microsoft.EntityFrameworkCore;

namespace DummyEcommApp.Catalog.DataAccess.Interfaces
{
	public interface ICatalogDbContext
	{
		public DbSet<Product> Products { get; set; }
		
		public DbSet<Category> Categories { get; set; }

		public DbSet<ProductItem> ProductItems { get; set; }
	}
}