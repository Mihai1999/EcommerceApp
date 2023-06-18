using DummyEcommApp.Catalog.Models;
using DummyEcommApp.Common.DataAccess;

namespace DummyEcommApp.Catalog.DataAccess.Interfaces
{
	public interface IProductRepository : IRepository<Product, Guid>
	{
	}
}
