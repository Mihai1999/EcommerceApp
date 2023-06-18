using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyEcommApp.Catalog.DataAccess
{
	public static class ServiceCollectionExtension
	{
		public static IServiceCollection AddCatalogDataAccess(this IServiceCollection services,
			string connectionString)
		{
			services.AddDbContext<CatalogDbContext>(
				options => options.UseSqlServer(connectionString));

			return services;
		}
	}
}
