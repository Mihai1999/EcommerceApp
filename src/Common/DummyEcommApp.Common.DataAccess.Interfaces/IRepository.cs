
namespace DummyEcommApp.Common.DataAccess
{
	public interface IRepository<TEntity, TKey>
	{
		Task Add(TEntity entity);

		Task AddRange(IEnumerable<TEntity> entities);

		Task<TEntity> GetById(TKey id);

		void Delete(TEntity entity);

		void DeleteRange(IEnumerable<TEntity> entities);
	}
}
