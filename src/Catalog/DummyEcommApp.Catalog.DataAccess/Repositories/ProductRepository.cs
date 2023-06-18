using DummyEcommApp.Catalog.DataAccess.Interfaces;
using DummyEcommApp.Catalog.Models;
using DummyEcommApp.Common.DataAccess;

namespace DummyEcommApp.Catalog.DataAccess.Repositories
{
    public class ProductRepository : Repository<CatalogDbContext,Product, Guid>, IRepository<Product, Guid>
    {
        public ProductRepository(CatalogDbContext dbContext) : base(dbContext)
        {
        }
    }
}