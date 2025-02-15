using CultureScan.Domain.Base;
using CultureScan.Infra.Repositories.Abstractions.Base;
using Microsoft.EntityFrameworkCore.Storage;

namespace CultureScan.Infra.Repositories.Abstractions.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        Task<IDbContextTransaction> BeginTransactionAsync();
        Task CommitTransactionAsync(IDbContextTransaction transaction);
        Task RollBackTransactionAsync(IDbContextTransaction transaction);
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : Entity<TEntity>;
    }
}
