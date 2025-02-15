using CultureScan.Domain.Perguntas;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CultureScan.Infra.Repositories.Context;

public class CultureScanContext : DbContext
{
    public DbSet<Carreira> Carreiras { get; set; }
    public DbSet<Chefia> Chefias { get; set; }
    public DbSet<Comunicacao> Comunicacoes { get; set; }
    public DbSet<Corporativo> Corporativos { get; set; }
    public DbSet<Processo> Processos { get; set; }
    public DbSet<Remuneracao> Remuneracoes { get; set; }

    public CultureScanContext(DbContextOptions<CultureScanContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
        => builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
}