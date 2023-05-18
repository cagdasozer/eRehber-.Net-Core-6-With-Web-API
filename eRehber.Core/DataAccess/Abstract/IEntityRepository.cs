using eRehber.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace eRehber.Core.DataAccess.Abstract
{
	public interface IEntityRepository<TEntity> where TEntity : class, IEntity, new()
	{
		Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties);
		Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties);
		Task<TEntity> FindAsync(object id);
		Task<TEntity> AddAsync(TEntity entity);
		Task<TEntity> UpdateAsync(TEntity entity);
		Task<TEntity> DeleteAsync(TEntity entity);

		Task<int> SaveAsync();
	}
}
