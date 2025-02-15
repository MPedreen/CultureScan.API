using CultureScan.Domain.Base;
using CultureScan.Domain.Perguntas;
using CultureScan.Infra.Repositories.Abstractions.Base;
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

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : Entity<TEntity>
            => typeof(TEntity) switch
            {
                Type tipo when tipo == typeof(Carreira) => (IRepository<TEntity>)CarreiraRepository,
                Type tipo when tipo == typeof(Chefia) => (IRepository<TEntity>)ChefiaRepository,
                Type tipo when tipo == typeof(Comunicacao) => (IRepository<TEntity>)ComunicacaoRepository,
                Type tipo when tipo == typeof(Corporativo) => (IRepository<TEntity>)CorporativoRepository,
                Type tipo when tipo == typeof(Processo) => (IRepository<TEntity>)ProcessoRepository,
                Type tipo when tipo == typeof(Remuneracao) => (IRepository<TEntity>)RemuneracaoRepository,
                _ => null
            };
    }
}
