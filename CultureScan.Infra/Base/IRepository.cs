using CultureScan.Domain.Base;
using System.Linq.Expressions;

namespace CultureScan.Infra.Repositories.Abstractions.Base;

public interface IRepository<TEntity> where TEntity : Entity<TEntity>
{
    Task AddAsync(TEntity entity);
    Task AddRangeAsync(IEnumerable<TEntity> entities);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
    Task DeleteRangeAsync(IEnumerable<TEntity> entities);
    Task<TEntity> GetByIdAsync(Guid id);
    Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);
    Task<IReadOnlyList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null);
}
