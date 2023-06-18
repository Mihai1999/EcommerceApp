using Microsoft.EntityFrameworkCore;

namespace DummyEcommApp.Catalog.DataAccess.ModelConfiguration
{
	public static class ModelConfigurationExtensions
	{
		public static ModelBuilder ApplyCatalogConfigurations(this ModelBuilder builder)
		{
			builder.ApplyConfiguration(new ProductConfiguration())
				.ApplyConfiguration(new CategoryConfiguration())
				.ApplyConfiguration(new ProductItemConfiguration());

			return builder;
		}
	}
}
