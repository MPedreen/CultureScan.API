using CultureScan.Domain.Base;
using CultureScan.Infra.Repositories.Abstractions.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CultureScan.Infra.Repositories.Repositories.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity<TEntity>
    {
        protected readonly DbSet<TEntity> _entity;

        protected readonly DbContext _dbContext;

        public Repository(DbSet<TEntity> entity, DbContext dbContext)
        {
            _entity = entity;
            _dbContext = dbContext;
        }

        public virtual async Task AddAsync(TEntity entity)
            => await _entity.AddAsync(entity);

        public virtual async Task AddRangeAsync(IEnumerable<TEntity> entities)
            => await _entity.AddRangeAsync(entities);

        public virtual Task UpdateAsync(TEntity entity)
        {
            _entity.Update(entity);
            return Task.CompletedTask;
        }

        public virtual Task DeleteAsync(TEntity entity)
        {
            _entity.Remove(entity);
            return Task.CompletedTask;
        }

        public virtual Task DeleteRangeAsync(IEnumerable<TEntity> entities)
        {
            _entity.RemoveRange(entities);
            return Task.CompletedTask;
        }

        public virtual async Task<TEntity> GetByIdAsync(Guid id)
            => await _entity.FindAsync(id);

        public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
            => await _entity.AsNoTracking().FirstOrDefaultAsync(predicate);

        public virtual async Task<IReadOnlyList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            if (predicate is null)
                return await _entity.AsNoTracking().ToListAsync();

            return await _entity.Where(predicate).AsNoTracking().ToListAsync();
        }
    }
}
