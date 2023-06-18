using Microsoft.EntityFrameworkCore;

namespace DummyEcommApp.Common.DataAccess.Interfaces
{
	public interface IDbContext
	{
		DbSet<TEntity> Set<TEntity>()
			where TEntity : class;
	}
}