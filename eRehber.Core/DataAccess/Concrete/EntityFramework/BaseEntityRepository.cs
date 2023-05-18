using eRehber.Core.DataAccess.Abstract;
using eRehber.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace eRehber.Core.DataAccess.Concrete.EntityFramework
{
	public class BaseEntityRepository<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
	{
		protected readonly DbContext _context;
		public BaseEntityRepository(DbContext context)
		{
			_context = context;
		}

		public async Task<TEntity> AddAsync(TEntity entity)
		{
			await _context.Set<TEntity>().AddAsync(entity);
			return entity;
		}

		public async Task<TEntity> DeleteAsync(TEntity entity)
		{
			await Task.Run(() => { _context.Set<TEntity>().Remove(entity); });
			return entity;
		}

		public async Task<TEntity> FindAsync(object id)
		{
			return await _context.Set<TEntity>().FindAsync(id);
		}

		public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
		{
			IQueryable<TEntity> query = _context.Set<TEntity>();
			if (predicate != null)
			{
				query = query.Where(predicate);
			}
			if (includeProperties.Any())
			{
				foreach (var includeProperty in includeProperties)
				{
					query = query.Include(includeProperty);
				}
			}
			return await query.ToListAsync();
		}

		public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
		{
			IQueryable<TEntity> query = _context.Set<TEntity>();
			query = query.Where(predicate);
			if (includeProperties.Any())
			{
				foreach (var includeProperty in includeProperties)
				{
					query = query.Include(includeProperty);
				}
			}
			return await query.SingleOrDefaultAsync();
		}

		public async Task<int> SaveAsync()
		{
			return await _context.SaveChangesAsync();
		}

		public async Task<TEntity> UpdateAsync(TEntity entity)
		{
			await Task.Run(() => { _context.Set<TEntity>().Update(entity); });
			return entity;
		}
	}
}
