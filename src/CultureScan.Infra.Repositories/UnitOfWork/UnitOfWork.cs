using CultureScan.Infra.Repositories.Abstractions.UnitOfWork;
using CultureScan.Infra.Repositories.Context;
using Microsoft.EntityFrameworkCore.Storage;

namespace CultureScan.Infra.Repositories.UnitOfWork
{
    public partial class UnitOfWork : IUnitOfWork
    {
        private readonly CultureScanContext _context;

        public UnitOfWork(CultureScanContext context)
            => _context = context;

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
            => await _context.Database.BeginTransactionAsync();

        public async Task CommitTransactionAsync(IDbContextTransaction transaction)
            => await transaction.CommitAsync();

        public async Task RollBackTransactionAsync(IDbContextTransaction transaction)
            => await transaction.RollbackAsync();
    }
}
