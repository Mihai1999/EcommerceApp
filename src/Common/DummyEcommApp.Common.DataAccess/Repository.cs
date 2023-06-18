using DummyEcommApp.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace DummyEcommApp.Common.DataAccess
{
	public class Repository<TContext, TEntity, TKey> : IRepository<TEntity, TKey>
		where TEntity : BaseEntity<TKey>
		where TContext : DbContext
	{
		private readonly TContext dbContext;

		protected IQueryable<TEntity> Entities => DefaultQuery(dbContext.Set<TEntity>());

		public Repository(TContext dbContext)
		{
			this.dbContext = dbContext;
		}

		protected virtual IQueryable<TEntity> DefaultQuery(DbSet<TEntity> dbSet)
		{
			return dbSet;
		}

		public async Task Add(TEntity entity)
		{
			if (entity == null)
			{
				throw new ArgumentNullException(nameof(entity));
			}

			await dbContext.Set<TEntity>().AddAsync(entity);
		}

		public async Task AddRange(IEnumerable<TEntity> entities)
		{
			if (entities == null || !entities.Any())
			{
				throw new ArgumentException(nameof(entities));
			}

			await dbContext.Set<TEntity>().AddRangeAsync(entities);
		}

		public Task<TEntity> GetById(TKey id)
		{
			return Entities.SingleOrDefaultAsync(x => x.Id.Equals(id));
		}

		public void Delete(TEntity entity)
		{
			dbContext.Set<TEntity>().Remove(entity);
		}

		public void DeleteRange(IEnumerable<TEntity> entities)
		{
			dbContext.Set<TEntity>().RemoveRange(entities);
		}
	}
}
