using Microsoft.EntityFrameworkCore.Storage;

namespace CultureScan.Infra.Repositories.Abstractions.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        Task<IDbContextTransaction> BeginTransactionAsync();
        Task CommitTransactionAsync(IDbContextTransaction transaction);
        Task RollBackTransactionAsync(IDbContextTransaction transaction);
    }
}
